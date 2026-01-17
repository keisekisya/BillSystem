using System;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using BillSystem.Const;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.IO;

namespace BillSystem
{
    public partial class BillForm
    {
        // 見出し開始位置(X)
        private const int TITLE_X = 37;

        // 見出し開始位置(Y)
        private const int TITLE_Y = 37;

        // 見出し日付開始位置(X)
        private const int DATE_X = 300;

        // 見出し日付開始位置(Y)
        private const int DATE_Y = 37;

        // 見出し日付ライン開始位置(X)
        private const int DATE_LINE_X = 300;

        // 見出し日付ライン開始位置(Y)
        private const int DATE_LINE_Y = 60;

        // 見出し日付ライン幅
        private const int DATE_LINE_WIDTH = 255;

        // 見出しページNO開始位置(X)
        private const int PAGE_NO_X = 645;

        // 見出しページNO開始位置(Y)
        private const int PAGE_NO_Y = 37;

        // 見出しページライン開始位置(X)
        private const int PAGE_LINE_X = 640;

        // 見出しページライン開始位置(Y)
        private const int PAGE_LINE_Y = 60;

        // 見出しページライン幅
        private const int PAGE_LINE_WIDTH = 140;

        // １ページの印刷行数
        private const int PRINT_LINE = 20;

        // １行の高さ
        private const int ONE_LINE_HEIGHT = 37;

        // 最後の行の高さ
        private const int LAST_LINE_HEIGHT = 37;

        // 請求文開始位置
        private const int WORK_START_Y = 175;

        // 枠 開始位置(Y座標)
        private const int WAKU_START_Y = 200;

        // 枠 開始位置(X座標)
        private const int WAKU_START_X = 5;

        // 枠の幅
        private const int WAKU_WIDTH = 770;

        // 枠のヘッダー
        private const int WAKU_HEADER_HEIGHT_1 = 50;

        // 枠のヘッダー
        private const int WAKU_HEADER_HEIGHT_2 = 30;

        // 縦１線の幅(日付)
        private const int HEIGHT_LINE_1 = 60;

        // 縦２線の幅(品名)
        private const int HEIGHT_LINE_2 = 370;

        // 縦３線の幅(数量)
        private const int HEIGHT_LINE_3 = 80;

        // 縦４線の幅(単価)
        private const int HEIGHT_LINE_4 = 100;

        // 縦５線の幅(金額)
        private const int HEIGHT_LINE_5 = 100;

        // 縦５線の幅(摘要)
        private const int HEIGHT_LINE_6 = WAKU_WIDTH - (HEIGHT_LINE_1 + HEIGHT_LINE_2 + HEIGHT_LINE_3 + HEIGHT_LINE_4 + HEIGHT_LINE_5);

        // 罫線の上からの開始文字位置
        private const int HEIGHT_STAET_DATA_TOP = 15;

        // 罫線の上からの開始文字位置(2行になった場合)
        private const int HEIGHT_STAET_DATA_TOP2 = 7;

        // 罫線の横からの開始文字位置
        private const int WIDTH_STAET_DATA_TOP = 5;

        // 請求先開始位置(X)
        private const int TO_NAME_X = 30;
        // 請求先開始位置(Y)
        private const int TO_NAME_Y = 100;

        // 請求元開始位置(Y)
        private const int FROM_NAME_Y = 100;

        private int print_count = 0;
        private int print_page = 0;
        private int print_sum = 0;
        private string day = "01";

        private bool getAddressFlg = false;

        private AddressInfo adrInfo;

        private string printDate;

////////////////////////////////////////////////////////////////////////////////////
// 通常印刷
////////////////////////////////////////////////////////////////////////////////////


        ///////////////////////////////////////////
        // 印刷ボタン押下時
        ///////////////////////////////////////////
        private void btnPrint_Click(object sender, EventArgs e)
        {
            btnPrint.Enabled = false;
            if (gridDataCheck() == true)
            {
                printFunc();
            }
            btnPrint.Enabled = true;
        }

        private bool gridDataCheck()
        {
            for (int i = 0; i < gridViewBill.RowCount; i++)
            {
                DataGridViewRow row = gridViewBill.Rows[i];
                // 備考が「後で修正する」の場合
                if ((string)row.Cells[BillGridViewConst.REMARKSINDEX].Value == BillFormConst.AFTERREMARK)
                {
                    StringBuilder buf = new StringBuilder();
                    buf.Append(i + 1);
                    buf.Append("行の備考に「後で修正する」が入力されています。");
                    MessageBox.Show(buf.ToString(), "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        /////////////////////////////////////////////////////
        // 印刷処理
        /////////////////////////////////////////////////////
        private void printFunc()
        {
            // 保存されていない場合
            if (saveFlag)
            {
                DialogResult ret = MessageBox.Show("修正されていますが、保存していません。\n保存していないと印刷出来ません。\n保存しますか？",
                                                   "警告",
                                                   MessageBoxButtons.OKCancel,
                                                   MessageBoxIcon.Question,
                                                   MessageBoxDefaultButton.Button2);
                if (ret == DialogResult.OK)
                {
                    // マウスを砂時計に
                    Cursor.Current = Cursors.WaitCursor;
                    bool ret2 = save_func();
                    Cursor.Current = Cursors.Default;
                    if (!ret2)
                    {
                        MessageBox.Show("保存に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    return;
                }
            }

            printForm form = new printForm();
            form.day = day;
            form.ShowDialog(this);
            if (form.okFlag == false)
            {
                return;
            }
            day = form.day;

            // マウスを砂時計に
            Cursor.Current = Cursors.WaitCursor;

            // 住所情報を取得していない場合
            if (getAddressFlg == false)
            {
                if (DbAccessFunc.getAddressInfo(ref adrInfo) == false)
                {
                    MessageBox.Show("住所情報が登録されていません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    getAddressFlg = true;
                }
            }

            string gengou = "";
            try{
                gengou = yearUtil.getGenGou(gYear, gMonth);
            } catch(Exception){
                MessageBox.Show("元号取得失敗", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
              
            StringBuilder buf = new StringBuilder();
            buf.Append(gengou);
            buf.Append(" 年 ");
            string month = "";
            month = gMonth;
            if(month[0] == '0')
            {
                month = " " + month[1];
            }
            buf.Append(month);
            buf.Append(" 月 ");
            string tmpDay = day;
            if(tmpDay[0] == '0')
            {
                tmpDay = " " + tmpDay[1];
            }
            buf.Append(tmpDay);
            buf.Append(" 日 ");
            printDate = buf.ToString();

            print_count = 0;
            print_page = 0;
            try
            {
                int num = gridViewBill.RowCount / PRINT_LINE;
                if (gridViewBill.RowCount % PRINT_LINE > 0)
                {
                    num++;
                }

                print_sum = num;
                String pdfPath = Properties.Settings.Default.PdfOutPath;
                String comptmp = gCompanyName.Length == 0 ? "会社指定なし" : gCompanyName;
                String pdffileName = pdfPath + @"\" + gYear + gMonth + "_" + comptmp + ".pdf";
                bool pdfFlg = Properties.Settings.Default.Pdf && Directory.Exists(pdfPath);
                if (pdfFlg)
                {
                    printBillData.PrinterSettings = new PrinterSettings()
                    {
                        // Windows10 から利用可能
                        PrinterName = "Microsoft Print to PDF",
                        // 出力先をfileに指定する
                        PrintToFile = true,
                        PrintFileName = Path.Combine(pdffileName),
                    };
                }
                printBillData.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(10, 10, 10, 10);
                printBillData.Print();
                if (pdfFlg)
                {
                    if (pdffileName.Length > 0 && File.Exists(pdffileName))
                    {
                        String app = Properties.Settings.Default.PdfOpenApp;
                        if (app.Length > 0)
                        {
                            System.Diagnostics.Process.Start(app, pdffileName);
                        }
                        else
                        {
                            System.Diagnostics.Process.Start(pdffileName);
                        }
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("印刷", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Console.WriteLine(ee);
                return;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }


        /////////////////////////////////////////////////////
        // 印刷処理
        /////////////////////////////////////////////////////
        private void printBillData_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // 見出しフォント
            Font f_T = new Font("ＭＳ 明朝", 16);

            // 請求文フォント
            Font f_W = new Font("ＭＳ 明朝", 13);

            // ベースフォント
            Font f = new Font("ＭＳ 明朝", 10);

            // 日付～用フォント
            Font fks = new Font("ＭＳ 明朝", 8);

            // 罫線用ペン
            Pen underlinePen = new Pen(Color.Black, 0.3F);

            int waku_x = WAKU_START_X + e.MarginBounds.Left;
            int waku_y = WAKU_START_Y + e.MarginBounds.Top;
            int line_height = (ONE_LINE_HEIGHT * PRINT_LINE) + WAKU_HEADER_HEIGHT_1 + WAKU_HEADER_HEIGHT_2;
            int waku_height = line_height + LAST_LINE_HEIGHT;

            StringFormat drawFormat = new StringFormat();
            drawFormat.Alignment = StringAlignment.Far;

            StringFormat drawCenterFormat = new StringFormat();
            drawCenterFormat.Alignment = StringAlignment.Center;

            StringFormat drawNearFormat = new StringFormat();
            drawNearFormat.Alignment = StringAlignment.Near;

            // ページ番号
            print_page++;

            //////////////////////////////////////////////////////////////////
            // 見出しの描画

            // タイトル
            e.Graphics.DrawString("請  求  書", f_T, Brushes.Black,
                                  e.MarginBounds.Left + TITLE_X, e.MarginBounds.Top + TITLE_Y,
                                  drawNearFormat);

            if (print_page == 1)
            {
                // 日付
                e.Graphics.DrawString(printDate, f_T, Brushes.Black,
                                      e.MarginBounds.Left + DATE_X, e.MarginBounds.Top + DATE_Y,
                                      drawNearFormat);

                // 日付横線
                e.Graphics.DrawLine(underlinePen, e.MarginBounds.Left + DATE_LINE_X,
                                                  e.MarginBounds.Top + DATE_LINE_Y,
                                                  e.MarginBounds.Left + DATE_LINE_X + DATE_LINE_WIDTH,
                                                  e.MarginBounds.Top + DATE_LINE_Y);
            }

            // ページNO
            e.Graphics.DrawString("NO.", f_T, Brushes.Black,
                                  e.MarginBounds.Left + PAGE_NO_X, e.MarginBounds.Top + PAGE_NO_Y,
                                  drawNearFormat);

            // ページ数の描画
            StringBuilder buf = new StringBuilder();
            buf.Append(print_page);
            buf.Append(" / ");
            buf.Append(print_sum);

            e.Graphics.DrawString(buf.ToString(), f_T, Brushes.Black,
                                  e.MarginBounds.Left + PAGE_NO_X + 45, e.MarginBounds.Top + PAGE_NO_Y,
                                  drawNearFormat);

            // ページ横線
            e.Graphics.DrawLine(underlinePen, e.MarginBounds.Left + PAGE_LINE_X,
                                              e.MarginBounds.Top + PAGE_LINE_Y,
                                              e.MarginBounds.Left + PAGE_LINE_X + PAGE_LINE_WIDTH,
                                              e.MarginBounds.Top + PAGE_LINE_Y);

            // 請求元
            e.Graphics.DrawString(adrInfo.to_name, f_W, Brushes.Black,
                                  e.MarginBounds.Left + TO_NAME_X, e.MarginBounds.Top + TO_NAME_Y,
                                  drawNearFormat);

            // 請求先
            float address1Width = e.Graphics.MeasureString(adrInfo.from_address1, f).Width;
            float address2Width = e.Graphics.MeasureString(adrInfo.from_address2, f).Width;
            float from_width;
            if (address1Width > address2Width)
            {
                from_width = address1Width;
            }
            else
            {
                from_width = address2Width;
            }

            float from_y = waku_x + WAKU_WIDTH - from_width;

            StringBuilder fromBuf = new StringBuilder();
            fromBuf.Append(adrInfo.from_address1);
            fromBuf.Append("\n");
            fromBuf.Append(adrInfo.from_address2);
            fromBuf.Append("\n");
            fromBuf.Append(adrInfo.from_name);
            fromBuf.Append("\n");
            fromBuf.Append(adrInfo.from_tel);
            fromBuf.Append("\n");
            fromBuf.Append("登録番号：" + adrInfo.from_invoice_no);
            e.Graphics.DrawString(fromBuf.ToString(), f, Brushes.Black,
                                  from_y, e.MarginBounds.Top + FROM_NAME_Y,
                                  drawNearFormat);


            // 請求文の
            e.Graphics.DrawString("下記のとおり御請求申し上げます", f_W, Brushes.Black,
                                  e.MarginBounds.Left + 5, e.MarginBounds.Top + WORK_START_Y,
                                  drawNearFormat);

            //////////////////////////////////////////////////////////////////
            // 罫線の描画

            // 枠
            e.Graphics.DrawRectangle(underlinePen, waku_x, waku_y, WAKU_WIDTH, waku_height);

            int tmp_line_y = waku_y + WAKU_HEADER_HEIGHT_1;

            // ヘッダー横線１
            e.Graphics.DrawLine(underlinePen, waku_x, tmp_line_y, waku_x + WAKU_WIDTH, tmp_line_y);

            tmp_line_y = tmp_line_y + WAKU_HEADER_HEIGHT_2;
            int header2_line_y = tmp_line_y;

            // ヘッダー横線２
            e.Graphics.DrawLine(underlinePen, waku_x, tmp_line_y, waku_x + WAKU_WIDTH, tmp_line_y);
            
            // 横線
            int tmp_width_x = waku_x + WAKU_WIDTH;
            for (int i = 0; i < PRINT_LINE; i++)
            {
                tmp_line_y = tmp_line_y + ONE_LINE_HEIGHT;
                e.Graphics.DrawLine(underlinePen, waku_x, tmp_line_y, tmp_width_x, tmp_line_y);
            }

            // 縦　開始位置
            int height_start_y = waku_y + WAKU_HEADER_HEIGHT_1;
            // 縦　終了位置
            int height_end_y = waku_y + waku_height;
            int height_end_y2 = waku_y + line_height;

            // 縦線
            int tmp_height_x = waku_x + HEIGHT_LINE_1;
            int tmp_height_x2 = waku_x + (HEIGHT_LINE_1/2);

            e.Graphics.DrawLine(underlinePen, tmp_height_x, height_start_y, tmp_height_x, height_end_y2);
            e.Graphics.DrawLine(underlinePen, tmp_height_x2, header2_line_y, tmp_height_x2, height_end_y2);

            tmp_height_x = tmp_height_x + HEIGHT_LINE_2;
            e.Graphics.DrawLine(underlinePen, tmp_height_x, height_start_y, tmp_height_x, height_end_y);

            tmp_height_x = tmp_height_x + HEIGHT_LINE_3;
            e.Graphics.DrawLine(underlinePen, tmp_height_x, height_start_y, tmp_height_x, height_end_y);

            tmp_height_x = tmp_height_x + HEIGHT_LINE_4;
            e.Graphics.DrawLine(underlinePen, tmp_height_x, height_start_y, tmp_height_x, height_end_y);

            tmp_height_x = tmp_height_x + HEIGHT_LINE_5;
            e.Graphics.DrawLine(underlinePen, tmp_height_x, height_start_y, tmp_height_x, height_end_y);

            //////////////////////////////////////////////////////////////////
            // ヘッダー文字の描画

            if (print_page == 1)
            {
                StringBuilder bufSum = new StringBuilder();
                bufSum.Append("合計金額    ");
                bufSum.Append(labelSumPrice.Text);
                // 日付
                e.Graphics.DrawString(bufSum.ToString(), f_T, Brushes.Black,
                                      waku_x + WIDTH_STAET_DATA_TOP, waku_y + 17,
                                      drawNearFormat);
            }

            int header_line_y = waku_y + WAKU_HEADER_HEIGHT_1 + HEIGHT_STAET_DATA_TOP;

            // 横開始位置
            int tmp_header__width_x = waku_x;

            // 日付
            e.Graphics.DrawString("月 日", f, Brushes.Black,
                                  tmp_header__width_x + (HEIGHT_LINE_1 /2), header_line_y,
                                  drawCenterFormat);

            tmp_header__width_x = tmp_header__width_x + HEIGHT_LINE_1;

            // 品名
            e.Graphics.DrawString("品     名", f, Brushes.Black,
                                  tmp_header__width_x + (HEIGHT_LINE_2 / 2), header_line_y,
                                  drawCenterFormat);

            tmp_header__width_x = tmp_header__width_x + HEIGHT_LINE_2;

            // 数量
            e.Graphics.DrawString("数 量", f, Brushes.Black,
                                  tmp_header__width_x + (HEIGHT_LINE_3 / 2), header_line_y,
                                  drawCenterFormat);

            tmp_header__width_x = tmp_header__width_x + HEIGHT_LINE_3;

            // 単価
            int temadai_width_x = tmp_header__width_x + (HEIGHT_LINE_4 / 2);
            e.Graphics.DrawString("単 価", f, Brushes.Black,
                                  temadai_width_x, header_line_y,
                                  drawCenterFormat);

            tmp_header__width_x = tmp_header__width_x + HEIGHT_LINE_4;

            // 金額
            e.Graphics.DrawString("金 額", f, Brushes.Black,
                                  tmp_header__width_x + (HEIGHT_LINE_5 / 2), header_line_y,
                                  drawCenterFormat);

            tmp_header__width_x = tmp_header__width_x + HEIGHT_LINE_5;

            // 摘要
            e.Graphics.DrawString("才 数", f, Brushes.Black,
                                  tmp_header__width_x + (HEIGHT_LINE_6 / 2), header_line_y,
                                  drawCenterFormat);


            // 合計
            e.Graphics.DrawString("合               計", f, Brushes.Black,
                                  waku_x + ((HEIGHT_LINE_1 + HEIGHT_LINE_2) / 2), waku_y + line_height + HEIGHT_STAET_DATA_TOP,
                                  drawCenterFormat);

            //////////////////////////////////////////////////////////////////
            // データの描画

            int count = 0;
            int tmp_data_y = waku_y + WAKU_HEADER_HEIGHT_1 + WAKU_HEADER_HEIGHT_2;
            bool nextflag = false;

            long sumPrice = 0;

            // データの描画
            for (int i = print_count; i < gridViewBill.RowCount; i++)
            {
                DataGridViewRow row = gridViewBill.Rows[i];
                count++;
                if (count > PRINT_LINE)
                {
                    print_count = i;
                    nextflag = true;
                    break;
                }

                int tmp_data_y2 = tmp_data_y + HEIGHT_STAET_DATA_TOP;

                // 横開始位置
                int tmp_height_width_x = waku_x;

                tmp_height_width_x = tmp_height_width_x + HEIGHT_LINE_1 / 2;

                // 初回の場合
                if (i == print_count)
                {
                    string tmpMonth = gMonth;
                    if (tmpMonth[0] == '0')
                    {
                        tmpMonth = " " + tmpMonth[1];
                    }

                    // 日付(月)
                    e.Graphics.DrawString(tmpMonth, f, Brushes.Black,
                                          tmp_height_width_x - WIDTH_STAET_DATA_TOP, tmp_data_y2,
                                          drawFormat);
                }

                tmp_height_width_x = tmp_height_width_x + HEIGHT_LINE_1 / 2;

                // 日付(日)
                string tmpDay = (string)row.Cells[BillGridViewConst.DAYINDEX].Value;
                if (tmpDay == "xx")
                {
                    StringBuilder tmpkaraDay = new StringBuilder();
                    tmpkaraDay.Append("1");
                    tmpkaraDay.Append("～");
                    tmpkaraDay.Append(glastDay);
                    e.Graphics.DrawString(tmpkaraDay.ToString(), fks, Brushes.Black,
                                          tmp_height_width_x + 1, tmp_data_y2,
                                          drawFormat);
                }
                else
                {
                    if (tmpDay[0] == '0')
                    {
                        tmpDay = " " + tmpDay[1];
                    }
                    e.Graphics.DrawString(tmpDay, f, Brushes.Black,
                                          tmp_height_width_x - WIDTH_STAET_DATA_TOP, tmp_data_y2,
                                          drawFormat);
                }

                // 品名
                StringBuilder bufHinmei = new StringBuilder();
                bufHinmei.Append((string)row.Cells[BillGridViewConst.COMPANYINDEX].Value);
                bufHinmei.Append(" ");
                bufHinmei.Append((string)row.Cells[BillGridViewConst.HINMEIINDEX].Value);

                // 種類と備考が設定されていない場合
                if ((string)row.Cells[BillGridViewConst.KINDINDEX].Value == "" &&
                    (string)row.Cells[BillGridViewConst.REMARKSINDEX].Value == "")
                {
                    e.Graphics.DrawString(bufHinmei.ToString(), f, Brushes.Black,
                                          tmp_height_width_x + WIDTH_STAET_DATA_TOP, tmp_data_y2,
                                          drawNearFormat);
                }
                else
                {
                    StringBuilder bufHinmei2 = new StringBuilder();

                    // 備考が設定されれている場合
                    if ((string)row.Cells[BillGridViewConst.REMARKSINDEX].Value != "")
                    {
                        bufHinmei2.Append((string)row.Cells[BillGridViewConst.REMARKSINDEX].Value);
                    }

                    // 種類が設定されている場合
                    if ((string)row.Cells[BillGridViewConst.KINDINDEX].Value != "")
                    {
//                        if (bufHinmei2.Length != 0)
//                        {
//                            bufHinmei2.Append(" ");
//                        }
                        bufHinmei2.Append("【");
                        bufHinmei2.Append((string)row.Cells[BillGridViewConst.KINDINDEX].Value);
                        bufHinmei2.Append("】");
                    }


                    StringBuilder calcBuf = new StringBuilder(bufHinmei.ToString()).Append(" ").Append(bufHinmei2.ToString());

                    float hinmeiWidth = e.Graphics.MeasureString(calcBuf.ToString(), f).Width;
                    float hinmeiHeight = e.Graphics.MeasureString(calcBuf.ToString(), f).Height;

                    // 文字幅が枠を超える場合
                    if (hinmeiWidth > HEIGHT_LINE_2 + WIDTH_STAET_DATA_TOP)
                    {
                        int tmp_hinmei_y = tmp_data_y + HEIGHT_STAET_DATA_TOP2;
                        e.Graphics.DrawString(bufHinmei.ToString(), f, Brushes.Black,
                                              tmp_height_width_x + WIDTH_STAET_DATA_TOP, tmp_hinmei_y,
                                              drawNearFormat);
                        e.Graphics.DrawString(bufHinmei2.ToString(), f, Brushes.Black,
                                              tmp_height_width_x + HEIGHT_LINE_2 - 2, tmp_hinmei_y + hinmeiHeight,
                                              drawFormat);
                    }
                    else
                    {
                        e.Graphics.DrawString(calcBuf.ToString(), f, Brushes.Black,
                                              tmp_height_width_x + WIDTH_STAET_DATA_TOP, tmp_data_y2,
                                              drawNearFormat);
                    }
                }

                // 数量(右寄り)
                tmp_height_width_x = tmp_height_width_x + HEIGHT_LINE_2 + HEIGHT_LINE_3;
                e.Graphics.DrawString((string)row.Cells[BillGridViewConst.NUMINDEX].Value, f, Brushes.Black,
                                      tmp_height_width_x - WIDTH_STAET_DATA_TOP, tmp_data_y2,
                                      drawFormat);

                // 単価
                tmp_height_width_x = tmp_height_width_x + HEIGHT_LINE_4;
                if ((string)row.Cells[BillGridViewConst.TEMAFLGINDEX].Value == "1")
                {
                    // 右寄り
                    e.Graphics.DrawString((string)row.Cells[BillGridViewConst.TANKAINDEX].Value, f, Brushes.Black,
                                          tmp_height_width_x - WIDTH_STAET_DATA_TOP, tmp_data_y2,
                                          drawFormat);
                }
                else
                {
                    // 手間代の場合は中央寄り
                    e.Graphics.DrawString((string)row.Cells[BillGridViewConst.TANKAINDEX].Value, f, Brushes.Black,
                                          temadai_width_x, tmp_data_y2,
                                          drawCenterFormat);
                }

                // 価格(右寄り)
                tmp_height_width_x = tmp_height_width_x + HEIGHT_LINE_5;
                e.Graphics.DrawString((string)row.Cells[BillGridViewConst.PRICEINDEX].Value, f, Brushes.Black,
                                      tmp_height_width_x - WIDTH_STAET_DATA_TOP, tmp_data_y2,
                                      drawFormat);

                sumPrice = sumPrice + long.Parse(UtilString.comaDel((string)row.Cells[BillGridViewConst.PRICEINDEX].Value));

                // 率(右寄り)
                tmp_height_width_x = tmp_height_width_x + HEIGHT_LINE_6;
                e.Graphics.DrawString((string)row.Cells[BillGridViewConst.RITUINDEX].Value, f, Brushes.Black,
                                      tmp_height_width_x - WIDTH_STAET_DATA_TOP, tmp_data_y2,
                                      drawFormat);

                tmp_data_y = tmp_data_y + ONE_LINE_HEIGHT;
            }

            // １ページの合計金額
            int tmp_price_x = waku_x + HEIGHT_LINE_1 + HEIGHT_LINE_2 + HEIGHT_LINE_3 + HEIGHT_LINE_4 + HEIGHT_LINE_5;
            e.Graphics.DrawString(String.Format("{0:n0}",sumPrice), f, Brushes.Black,
                                  tmp_price_x - WIDTH_STAET_DATA_TOP, waku_y + line_height + HEIGHT_STAET_DATA_TOP,
                                  drawFormat);

            e.HasMorePages = nextflag;
        }
    }
}
