using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using BillSystem.Const;

namespace BillSystem
{
    public partial class BillForm : Form
    {
        // 日付1～末
        private const string DAYALL = "xx";

        private int instupdflag = ModoConst.ADD;
        public string gYear { get; set; }
        public string gMonth { get; set; }
        public string gCompanyCode { get; set; }
        public string gCompanyName { get; set; }

        private bool saveFlag = false;
        private Dictionary<string, string> kindTable;
        private string glastDay = "01";

        public BillForm()
        {
            InitializeComponent();
        }

        /////////////////////////////////////////////////////
        // 画面ロード押下時
        /////////////////////////////////////////////////////
        private void BillForm_Load(object sender, EventArgs e)
        {
            labelHaneiMsg.Visible = false;

            glastDay = UtilString.getLastDay(gYear, gMonth);
            labelYear.Text = gYear;
            labelMonth.Text = gMonth;
            labelSelectCompanyName.Text = gCompanyName;
            day = glastDay;

            // 日付のコンボボックスに設定
            int tmpLastDay = int.Parse(glastDay);
            for (int i = 1; i <= tmpLastDay; i++)
            {
                boxDay.Items.Add(String.Format("{0:D2}", i));
            }
            boxDay.Items.Add(DAYALL);

            // 会社コードが設定されていない場合(種類がいる場合)
            if (gCompanyCode == "")
            {
                boxDay.Text = "01";
                boxKind.Enabled = true;
                labelKind.Enabled = true;
            }
            else
            {
                boxDay.Text = DAYALL;
                boxKind.Enabled = false;
                labelKind.Enabled = false;
            }

            // 品名
            labelHinmei.Text = "";
            // 会社コード
            textCompanyCode.Text = gCompanyCode;
            // 会社名
            labelCompany.Text = gCompanyName;


            /////////////////////////////////////////////////////////
            // グリッドの設定
            /////////////////////////////////////////////////////////

            // 行の高さを設定
            gridViewBill.RowTemplate.Height = 36;

            // フォントを設定
            gridViewBill.Font = new System.Drawing.Font("MS UI Gothic", 13.80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));

            ///////////////////////////////////////////////
            // DBよりデータを取得
            ///////////////////////////////////////////////
            using (SqlConnection conn = new SqlConnection(BillFormConst.CONNECT))
            {
                SqlCommand com = null;
                try
                {
                    /////////////////////////////////////////////////////////
                    // グリッドにデータを設定
                    /////////////////////////////////////////////////////////

                    StringBuilder sqlbuf = new StringBuilder();
                    sqlbuf.Append("SELECT A.DAY,C.NAME COMPANY,B.NAME HINMEI,D.NAME KIND,A.REMARKS,A.NUM,A.TANKA,A.PRICE,A.RITU");
                    sqlbuf.Append(",A.COMPANY_CODE,A.HINMEI_CODE,A.KIND_CODE,A.TEMA_FLG ");
                    sqlbuf.Append("FROM (((TBLT_PRICE A ");
                    sqlbuf.Append("INNER JOIN TBLM_HINMEI B ON A.HINMEI_CODE = B.CODE AND A.COMPANY_CODE = B.COMPANY_CODE) ");
                    sqlbuf.Append("INNER JOIN TBLM_COMPANY C ON A.COMPANY_CODE = C.CODE) ");
                    sqlbuf.Append("LEFT OUTER JOIN TBLM_KIND D ON A.KIND_CODE = D.CODE) ");
                    sqlbuf.Append("WHERE A.YEAR = @year AND A.MONTH = @month AND KEY_COMPANY_CODE = @key_company_code ");
                    sqlbuf.Append("ORDER BY A.SHOW_NUM");

                    conn.Open();
                    com = new SqlCommand(sqlbuf.ToString());
                    com.Connection = conn;
                    com.Parameters.AddWithValue("@year", gYear);
                    com.Parameters.AddWithValue("@month", gMonth);
                    com.Parameters.AddWithValue("@key_company_code", gCompanyCode);

                    SqlDataReader cReader = com.ExecuteReader();

                    while (cReader.Read())
                    {
                        string tanka;
                        if (cReader["TEMA_FLG"].ToString() == "1")
                        {
                            tanka = String.Format("{0:n2}", double.Parse(UtilString.syousuutennDel(cReader["TANKA"].ToString())));
                        }
                        else
                        {
                            tanka = "手間代";
                        }

                        string ritu;
                        double ritu_db = double.Parse(cReader["RITU"].ToString());
                        if (ritu_db != 0)
                        {
                            ritu = UtilString.syousuutennZeroDel(cReader["RITU"].ToString());
                        }
                        else
                        {
                            ritu = "";
                        }


                        gridViewBill.Rows.Add(cReader["DAY"].ToString(),
                                              cReader["COMPANY"].ToString(),
                                              cReader["HINMEI"].ToString(),
                                              cReader["KIND"].ToString(),
                                              cReader["REMARKS"].ToString(),
                                              String.Format("{0:n0}", double.Parse(UtilString.syousuutennDel(cReader["NUM"].ToString()))),
                                              tanka,
                                              String.Format("{0:n0}",double.Parse(UtilString.syousuutennDel(cReader["PRICE"].ToString()))),
                                              ritu,
                                              cReader["COMPANY_CODE"].ToString(),
                                              cReader["HINMEI_CODE"].ToString(),
                                              cReader["KIND_CODE"].ToString(),
                                              cReader["TEMA_FLG"].ToString()
                                              );
                    }
                    cReader.Close();

                    /////////////////////////////////////////////////////////
                    // 種類を取得
                    /////////////////////////////////////////////////////////

                    kindTable = new Dictionary<string,string>();

                    com.CommandText = "SELECT CODE, NAME FROM TBLM_KIND WHERE DEL_FLG <> '1' ORDER BY CODE";

                    cReader = com.ExecuteReader();

                    Graphics g = boxKind.CreateGraphics();
                    Font f = boxKind.Font;
                    float maxWith = 0;
                    boxKind.Items.Add("");
                    while (cReader.Read())
                    {
                        string tmpStr = cReader[1].ToString();
                        maxWith = Math.Max(maxWith, g.MeasureString(tmpStr, f).Width);
                        kindTable.Add(tmpStr, cReader[0].ToString());
                        boxKind.Items.Add(tmpStr);
                    }
                    cReader.Close();
                    boxKind.Width = (int)maxWith + 15;
                    boxKind.DropDownWidth = (int)maxWith;

                    /////////////////////////////////////////////////////////
                    // 読み取り専用かどうか取得
                    /////////////////////////////////////////////////////////

                    StringBuilder sqlbuf2 = new StringBuilder();
                    sqlbuf2.Append("SELECT READONLY ");
                    sqlbuf2.Append("FROM TBLT_PARAMSET ");
                    sqlbuf2.Append("WHERE YEAR = @year AND MONTH = @month ");

                    com.CommandText = sqlbuf2.ToString();
                    cReader = com.ExecuteReader();

                    string tmpReadOnly = "";
                    if (cReader.Read())
                    {
                        tmpReadOnly = cReader[0].ToString();
                    }
                    cReader.Close();

                    // 読み取り専用の場合
                    if (tmpReadOnly == "1")
                    {
                        groupBoxSetting.Enabled = false;
                        btnAdd.Enabled = false;
                        btnUpd.Enabled = false;
                        btnDel.Enabled = false;
                        btnUp.Enabled = false;
                        btnDown.Enabled = false;
                        btnSave.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DBエラー", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex);
                    this.Close();
                    return;
                }
                finally
                {
                    if (com != null)
                    {
                        com.Dispose();
                    }
                    conn.Close();
                    conn.Dispose();
                }

                if (gridViewBill.Rows.Count != 0)
                {
                    gridViewBill.Rows[gridViewBill.Rows.Count - 1].Selected = true;
                    if (gridViewBill.Rows.Count > 12)
                    {
                        gridViewBill.FirstDisplayedScrollingRowIndex = gridViewBill.Rows.Count - 11;
                    }
                }
            }
            
            radioTanka.Checked = true;
            radioTema.Checked = false;
            numericUpDownLine.Enabled = false;
            checkSounyu.Checked = false;
            radioEnabledChange();
            labelPriceMsg.Text = "";
            // 合計の計算
            calcSumPrice();
            // 初期値は追加に。
            instupdflag = ModoConst.ADD;
            // モードテキスト変更
            modeTextChange();
            textNum.Select();

            labelHaneiMsg.BackColor = Color.Black;
        }

        /////////////////////////////////////////////////////
        // グリッド行番号を表示
        /////////////////////////////////////////////////////
        private void gridViewBill_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // 行ヘッダのセル領域を、行番号を描画する長方形とする
            // （ただし右端に4ドットのすき間を空ける）
            Rectangle rect = new Rectangle(e.RowBounds.Location.X,
                                           e.RowBounds.Location.Y,
                                           gridViewBill.RowHeadersWidth - 4,
                                           e.RowBounds.Height);

            // 上記の長方形内に行番号を縦方向中央＆右詰めで描画する
            // フォントや前景色は行ヘッダの既定値を使用する
            TextRenderer.DrawText(e.Graphics,
                                  (e.RowIndex + 1).ToString(),
                                  gridViewBill.RowHeadersDefaultCellStyle.Font,
                                  rect,
                                  gridViewBill.RowHeadersDefaultCellStyle.ForeColor,
                                  TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /////////////////////////////////////////////////////
        // 単価ラジオボタン押下時
        /////////////////////////////////////////////////////
        private void radioTanka_CheckedChanged(object sender, EventArgs e)
        {
            radioEnabledChange();
        }

        /////////////////////////////////////////////////////
        // 手間代ラジオボタン押下時
        /////////////////////////////////////////////////////
        private void radioTema_CheckedChanged(object sender, EventArgs e)
        {
            radioEnabledChange();
        }

        /////////////////////////////////////////////////////
        // 単価、手間代ラジオボタンによる入力制御処理
        /////////////////////////////////////////////////////
        private void radioEnabledChange()
        {
            if (radioTanka.Checked == true)
            {
                textTanka.Enabled = true;
                btnTankaClear.Enabled = true;
                textTema.Enabled = false;
                btnTemaClear.Enabled = false;
                labelPrice.Enabled = true;
                labelPriceText.Enabled = true;
                checkRitu.Enabled = true;
                calcTanka();
                textTanka.Select();
            }
            else
            {
                textTanka.Text = "";
                checkRitu.Checked = false;
                textRitu.Text = "";
                labelPriceMsg.Text = "";
                textTanka.Enabled = false;
                btnTankaClear.Enabled = false;
                textTema.Enabled = true;
                btnTemaClear.Enabled = true;
                labelPrice.Enabled = false;
                labelPriceText.Enabled = false;
                checkRitu.Enabled = false;
                textTema.Select();
            }
            checkEnabledChange();
        }

        /////////////////////////////////////////////////////
        // 数量変更時処理
        /////////////////////////////////////////////////////
        private void textNum_TextChanged(object sender, EventArgs e)
        {
            if (textNum.Text != "")
            {
                if (!checkString.IsNumber(textNum.Text))
                {
                    textNum.Text = "0";
                    MessageBox.Show("数字のみを入力して下さい。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (radioTanka.Checked == true)
            {
                calcTanka();
            }
        }

        /////////////////////////////////////////////////////
        // 率チェック押下時
        /////////////////////////////////////////////////////
        private void checkRitu_CheckedChanged(object sender, EventArgs e)
        {
            checkEnabledChange();
            if (checkRitu.Checked == true)
            {
                textRitu.Select();
            }
            calcTanka();
        }

        /////////////////////////////////////////////////////
        // チェックボックスによる入力制御処理
        /////////////////////////////////////////////////////
        private void checkEnabledChange()
        {
            if (checkRitu.Checked == true && radioTanka.Checked == true)
            {
                textRitu.Enabled = true;
                btnRituClear.Enabled = true;
            }
            else
            {
                textRitu.Enabled = false;
                btnRituClear.Enabled = false;
            }
        }

        /////////////////////////////////////////////////////
        // 率変更時処理
        /////////////////////////////////////////////////////
        private void textRitu_TextChanged(object sender, EventArgs e)
        {
            if (textRitu.Text != "")
            {
                if (!checkString.IsDouble(textRitu.Text))
                {
                    textRitu.Text = "0";
                    MessageBox.Show("数字、小数点のみを入力して下さい。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            calcTanka();
        }

        /////////////////////////////////////////////////////
        // 単価変更時処理
        /////////////////////////////////////////////////////
        private void textTanka_TextChanged(object sender, EventArgs e)
        {
            if (textTanka.Text != "")
            {
                if (!checkString.IsDouble(textTanka.Text))
                {
                    textTanka.Text = "0";
                    MessageBox.Show("数字、小数点のみを入力して下さい。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string errValue = "";
                if (!checkString.IsSyousuTenLen(textTanka.Text, ref errValue))
                {
                    textTanka.Text = errValue;
                    MessageBox.Show("小数は2桁まで入力して下さい。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            calcTanka();
        }

        /////////////////////////////////////////////////////
        // 単価計算処理
        /////////////////////////////////////////////////////
        private void calcTanka()
        {
            long num = 0;
            double tanka = 0;

            if (textNum.Text != "")
            {
                num = long.Parse(textNum.Text);
            }

            if (textTanka.Text != "")
            {
                tanka = double.Parse(textTanka.Text);
            }

            double sum = num * tanka;
            if (checkRitu.Checked == true)
            {
                if (textRitu.Text != "")
                {
                    double tmpRitu = double.Parse(textRitu.Text);
                    sum = sum * tmpRitu;
                }
            }

            // 小数点以下のデータがある場合
            labelPrice.Text = String.Format("{0:n0}", (long)sum);
            if (UtilString.IsSyousuutennData(Convert.ToString(sum)) == true)
            {
                labelPriceMsg.Text = "小数点以下の値が発生しています。" + String.Format("{0:n2}", sum);
            }
            else
            {
                labelPriceMsg.Text = "";
            }
        }

        /////////////////////////////////////////////////////
        // 削除ボタン押下時
        /////////////////////////////////////////////////////
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (gridViewBill.SelectedRows.Count == 0)
            {
                MessageBox.Show("行を選択して下さい。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in gridViewBill.SelectedRows)
            {
                setGridRowData(row);
                break;
            }

            instupdflag = ModoConst.DEL;
            // モードテキスト変更
            modeTextChange();

            btnUp.Enabled = false;
            btnDown.Enabled = false;
            gridViewBill.Enabled = false;
            panel2.Enabled = false;
            panelAddLine.Enabled = false;
            checkSounyu.Checked = false;

            labelNum.Enabled = false;
            textNum.Enabled = false;
            btnNumClear.Enabled = false;
            textTanka.Enabled = false;
            btnTankaClear.Enabled = false;
            textTema.Enabled = false;
            btnTemaClear.Enabled = false;
            radioTanka.Enabled = false;
            radioTema.Enabled = false;
            checkRitu.Enabled = false;
            textRitu.Enabled = false;
            btnRituClear.Enabled = false;
            labelPriceText.Enabled = false;
            labelPrice.Enabled = false;
        }

        /////////////////////////////////////////////////////
        // 修正ボタン押下時
        /////////////////////////////////////////////////////
        private void btnUpd_Click(object sender, EventArgs e)
        {
            if (gridViewBill.SelectedRows.Count == 0)
            {
                MessageBox.Show("行を選択して下さい。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (DataGridViewRow row in gridViewBill.SelectedRows)
            {
                setGridRowData(row);
                break;
            }

            instupdflag = ModoConst.UPD;
            // モードテキスト変更
            modeTextChange();

            gridViewBill.Enabled = false;

            btnUp.Enabled = false;
            btnDown.Enabled = false;
            panel2.Enabled = true;
            panelAddLine.Enabled = false;
            checkSounyu.Checked = false;

            labelNum.Enabled = true;
            textNum.Enabled = true;
            btnNumClear.Enabled = true;
            radioTanka.Enabled = true;
            radioTema.Enabled = true;
            checkEnabledChange();
            radioEnabledChange();
            labelPriceText.Enabled = true;
            labelPrice.Enabled = true;
            calcTanka();
            boxDay.Select();
        }

        /////////////////////////////////////////////////////
        // 追加ボタン押下時
        /////////////////////////////////////////////////////
        private void btnAdd_Click(object sender, EventArgs e)
        {
            instupdflag = ModoConst.ADD;
            // モードテキスト変更
            modeTextChange();

            gridViewBill.Enabled = true;
            btnUp.Enabled = true;
            btnDown.Enabled = true;
            panel2.Enabled = true;
            panelAddLine.Enabled = true;
            checkSounyu.Checked = false;

            labelNum.Enabled = true;
            textNum.Enabled = true;
            btnNumClear.Enabled = true;
            radioTanka.Enabled = true;
            radioTema.Enabled = true;
            checkRitu.Enabled = true;
            checkRitu.Checked = false;
            textRitu.Enabled = false;
            radioEnabledChange();
            labelPriceText.Enabled = true;
            labelPrice.Enabled = true;
            calcTanka();
            boxDay.Select();
        }

        /////////////////////////////////////////////////////
        // 選択したグリッドの情報をテキストボックス等に反映
        /////////////////////////////////////////////////////
        private void setGridRowData(DataGridViewRow row)
        {
            // 日付
            boxDay.Text = (string)row.Cells[BillGridViewConst.DAYINDEX].Value;
            // 会社コード
            textCompanyCode.Text = (string)row.Cells[BillGridViewConst.COMPANY_CODEINDEX].Value;
            // 会社名
            labelCompany.Text = (string)row.Cells[BillGridViewConst.COMPANYINDEX].Value;
            // 品名コード
            textCode.Text = (string)row.Cells[BillGridViewConst.HINMEI_CODEINDEX].Value;
            // 品名
            labelHinmei.Text = (string)row.Cells[BillGridViewConst.HINMEIINDEX].Value;
            // 種類
            boxKind.Text = (string)row.Cells[BillGridViewConst.KINDINDEX].Value;
            // 備考
            textRemarks.Text = (string)row.Cells[BillGridViewConst.REMARKSINDEX].Value;
            // 数量
            textNum.Text = UtilString.comaDel((string)row.Cells[BillGridViewConst.NUMINDEX].Value);

            if ((string)row.Cells[BillGridViewConst.TEMAFLGINDEX].Value == "1")
            {
                radioTanka.Checked = true;
                textTanka.Text = UtilString.comaDel((string)row.Cells[BillGridViewConst.TANKAINDEX].Value);
                labelPrice.Text = (string)row.Cells[BillGridViewConst.PRICEINDEX].Value;
                textTema.Text = "";
            }
            else
            {
                radioTema.Checked = true;
                textTanka.Text = "";
                labelPrice.Text = "";
                textTema.Text = UtilString.comaDel((string)row.Cells[BillGridViewConst.PRICEINDEX].Value);
            }

            // 率
            if ((string)row.Cells[BillGridViewConst.RITUINDEX].Value != "")
            {
                checkRitu.Checked = true;
                textRitu.Text = (string)row.Cells[BillGridViewConst.RITUINDEX].Value;
            }
            else
            {
                checkRitu.Checked = false;
                textRitu.Text = "";
            }
        }

        /////////////////////////////////////////////////////
        // 反映ボタン押下時
        /////////////////////////////////////////////////////
        private void btnSet_Click(object sender, EventArgs e)
        {
            try
            {
                btnSet.Enabled = false;

                if (instupdflag == ModoConst.NOMODO)
                {
                    MessageBox.Show("モードを選択して下さい。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                StringBuilder bufMsg = new StringBuilder();

                if (textCompanyCode.Text == "")
                {
                    bufMsg.Append("会社コードを入力して下さい。\n");
                }
                if (textCode.Text == "")
                {
                    bufMsg.Append("品名コードを入力して下さい。\n");
                }
                // 会社コードが設定されている場合
                if (gCompanyCode == "")
                {
                    if (boxKind.Text == "")
                    {
                        bufMsg.Append("種類を選択して下さい。\n");
                    }
                }
                if (textNum.Text == "")
                {
                    bufMsg.Append("数量を入力して下さい。\n");
                }
                if (radioTanka.Checked)
                {
                    if (textTanka.Text == "")
                    {
                        bufMsg.Append("単価を入力して下さい。\n");
                    }
                    if (checkRitu.Checked && textRitu.Text == "")
                    {
                        bufMsg.Append("才数を入力して下さい。\n");
                    }
                }
                else
                {
                    if (textTema.Text == "")
                    {
                        bufMsg.Append("手間代を入力して下さい。\n");
                    }
                }

                if (bufMsg.Length != 0)
                {
                    MessageBox.Show(bufMsg.ToString(), "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 追加の場合
                if (instupdflag == ModoConst.ADD)
                {
                    string[] param = new string[BillGridViewConst.GRIDINDEXNUM];
                    if (setDataCheck(ref param) == false)
                    {
                        return;
                    }


                    bool lastFlag = false;
                    
                    // 途中に挿入する場合
                    if (checkSounyu.Checked == true)
                    {
                        // 指定行が総行数より大きい場合
                        if (numericUpDownLine.Value > gridViewBill.Rows.Count)
                        {
                            lastFlag = true;
                        }
                    }
                    else
                    {
                        lastFlag = true;
                    }

                    // 最後に追加する場合
                    if (lastFlag == true)
                    {
                        gridViewBill.Rows.Add(param);
                        gridViewBill.Rows[gridViewBill.Rows.Count - 1].Selected = true;
                        if (gridViewBill.Rows.Count > 11)
                        {
                            gridViewBill.FirstDisplayedScrollingRowIndex = gridViewBill.Rows.Count - 11;
                        }
                    }
                    else
                    {
                        int addIndex = (int)numericUpDownLine.Value - 1;
                        gridViewBill.Rows.Insert(addIndex, param);
                        gridViewBill.Rows[addIndex].Selected = true;
                        if (gridViewBill.Rows.Count > 12)
                        {
                            if (addIndex > 7)
                            {
                                gridViewBill.FirstDisplayedScrollingRowIndex = addIndex - 7;
                            }
                            else
                            {
                                gridViewBill.FirstDisplayedScrollingRowIndex = 0;
                            }
                            
                        }
                    }
                }
                // 修正の場合
                else if (instupdflag == ModoConst.UPD)
                {
                    foreach (DataGridViewRow row in gridViewBill.SelectedRows)
                    {
                        string[] param = new string[BillGridViewConst.GRIDINDEXNUM];
                        if (setDataCheck(ref param) == false)
                        {
                            return;
                        }

                        for (int i = 0; i < BillGridViewConst.GRIDINDEXNUM; i++)
                        {
                            row.Cells[i].Value = param[i];
                        }
                        break;
                    }
                }
                // 削除の場合
                else if (instupdflag == ModoConst.DEL)
                {
                    foreach (DataGridViewRow row in gridViewBill.SelectedRows)
                    {
                        DialogResult ret = MessageBox.Show("削除してよろしいでしょうか？",
                                                           "削除",
                                                           MessageBoxButtons.OKCancel,
                                                           MessageBoxIcon.Question,
                                                           MessageBoxDefaultButton.Button2);
                        if (ret == DialogResult.OK)
                        {
                            int index = row.Index;
                            gridViewBill.Rows.Remove(row);
                            if (gridViewBill.Rows.Count != 0)
                            {
                                if (index != 0)
                                {
                                    gridViewBill.Rows[index - 1].Selected = true;
                                }
                                btnDel_Click(null, null);
                            }
                        }
                        break;
                    }
                }

                // 合計の再計算
                calcSumPrice();

                timerMsg.Start();
                labelHaneiMsg.Visible = true;

                // 修正したのでフラグを立てる。
                saveFlag = true;
            }
            finally
            {
                btnSet.Enabled = true;
            }
        }

        /////////////////////////////////////////////////////
        // データ設定処理
        /////////////////////////////////////////////////////
        private bool setDataCheck(ref string[] param)
        {
            string hinmeiName = "";
            if (checkHinmeiCode(textCompanyCode.Text,textCode.Text, ref hinmeiName) == false)
            {
                MessageBox.Show("品名コードが存在しません。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            labelHinmei.Text = hinmeiName;

            // 日付
            param[BillGridViewConst.DAYINDEX] = boxDay.Text;
            // 会社コード
            param[BillGridViewConst.COMPANY_CODEINDEX] = textCompanyCode.Text;
            // 会社名
            param[BillGridViewConst.COMPANYINDEX] = labelCompany.Text;
            // 品名コード
            param[BillGridViewConst.HINMEI_CODEINDEX] = textCode.Text;
            // 品名
            param[BillGridViewConst.HINMEIINDEX] = labelHinmei.Text;
            // 種類
            param[BillGridViewConst.KINDINDEX] = boxKind.Text;
            // 種類コード
            if (boxKind.Text != "")
            {
                param[BillGridViewConst.KIND_CODEINDEX] = kindTable[boxKind.Text];
            }
            else
            {
                param[BillGridViewConst.KIND_CODEINDEX] = "";
            }

            // 備考
            param[BillGridViewConst.REMARKSINDEX] = textRemarks.Text.Trim();
            // 数量
            param[BillGridViewConst.NUMINDEX] = String.Format("{0:n0}", long.Parse(textNum.Text));;

            // 単価が選択されている場合
            if (radioTanka.Checked == true)
            {
                // 単価
                param[BillGridViewConst.TANKAINDEX] = String.Format("{0:n2}", double.Parse(textTanka.Text));
                // 価格
                param[BillGridViewConst.PRICEINDEX] = UtilString.syousuutennDel(labelPrice.Text);
                // 手間代フラグ
                param[BillGridViewConst.TEMAFLGINDEX] = "1";
            }
            else
            {
                // 単価
                param[BillGridViewConst.TANKAINDEX] = "手間代";
                // 価格
                param[BillGridViewConst.PRICEINDEX] = String.Format("{0:n0}", long.Parse(textTema.Text));
                // 手間代フラグ
                param[BillGridViewConst.TEMAFLGINDEX] = "2";
            }

            // 率が設定されている場合
            if (checkRitu.Checked == true)
            {
                param[BillGridViewConst.RITUINDEX] = textRitu.Text;
            }
            else
            {
                param[BillGridViewConst.RITUINDEX] = "";
            }

            return true;
        }

        /////////////////////////////////////////////////////
        // キャンセルボタン押下時
        /////////////////////////////////////////////////////
        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdd_Click(null, null);
//            gridViewBill.Enabled = true;
//            btnUp.Enabled = true;
//            btnDown.Enabled = true;
//            labelMode.Text = "";
//            instupdflag = ModoConst.NOMODO;
        }

        /////////////////////////////////////////////////////
        // 終了ボタン押下時
        /////////////////////////////////////////////////////
        private void btnClose_Click(object sender, EventArgs e)
        {
            // 保存されていない場合
            if (saveFlag)
            {
                DialogResult ret = MessageBox.Show("修正されていますが、保存していません。\n保存しますか？",
                                                   "警告",
                                                   MessageBoxButtons.OKCancel,
                                                   MessageBoxIcon.Question,
                                                   MessageBoxDefaultButton.Button2);
                if (ret == DialogResult.OK)
                {
                    // マウスを砂時計に
                    Cursor.Current = Cursors.WaitCursor;

                    bool ret2 = save_func();
                    if (!ret2)
                    {
                        MessageBox.Show("保存に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Cursor.Current = Cursors.Default;
                }
            }
            this.Close();
        }

        /////////////////////////////////////////////////////
        // 保存ボタン押下時
        /////////////////////////////////////////////////////
        private void btnSave_Click(object sender, EventArgs e)
        {
            // マウスを砂時計に
            Cursor.Current = Cursors.WaitCursor;

            bool ret = save_func();
            if (ret)
            {
                MessageBox.Show("保存しました。", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("保存に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
        }

        /////////////////////////////////////////////////////
        // 保存処理
        /////////////////////////////////////////////////////
        private bool save_func()
        {
            using (SqlConnection conn = new SqlConnection(BillFormConst.CONNECT))
            {
                SqlCommand com = null;
                SqlTransaction tran = null;
                try
                {
                    // マウスを砂時計に
                    Cursor.Current = Cursors.WaitCursor;

                    conn.Open();
                    com = conn.CreateCommand();

                    // トランザクション開始
                    tran = conn.BeginTransaction();

                    com.Connection = conn;
                    com.Transaction = tran;


                    com.CommandText = "DELETE FROM TBLT_PRICE WHERE YEAR=@year AND MONTH=@month AND KEY_COMPANY_CODE=@key_company_code";
                    com.Parameters.AddWithValue("@year", gYear);
                    com.Parameters.AddWithValue("@month", gMonth);
                    com.Parameters.AddWithValue("@key_company_code", gCompanyCode);

                    com.ExecuteNonQuery();

                    StringBuilder sqlbuf = new StringBuilder();
                    sqlbuf.Append("INSERT INTO TBLT_PRICE(");
                    sqlbuf.Append("YEAR,MONTH,KEY_COMPANY_CODE,SHOW_NUM,DAY,COMPANY_CODE,HINMEI_CODE,KIND_CODE,REMARKS,NUM,TANKA,RITU,PRICE,TEMA_FLG");
                    sqlbuf.Append(") values(");
                    sqlbuf.Append("@year,@month,@key_company_code,@show_num,@day,@company_code,@hinmei_code,@kind_code,@remarks,@num,@tanka,@ritu,@price,@tema_flg");
                    sqlbuf.Append(")");
                    com.CommandText = sqlbuf.ToString();

                    int index = 0;
                    foreach (DataGridViewRow row in gridViewBill.Rows)
                    {
                        com.Parameters.Clear();
                        com.Parameters.AddWithValue("@year", gYear);
                        com.Parameters.AddWithValue("@month", gMonth);
                        com.Parameters.AddWithValue("@key_company_code", gCompanyCode);
                        com.Parameters.AddWithValue("@show_num", index++);
                        com.Parameters.AddWithValue("@day", (string)row.Cells[BillGridViewConst.DAYINDEX].Value);
                        com.Parameters.AddWithValue("@company_code", (string)row.Cells[BillGridViewConst.COMPANY_CODEINDEX].Value);
                        com.Parameters.AddWithValue("@hinmei_code", (string)row.Cells[BillGridViewConst.HINMEI_CODEINDEX].Value);
                        com.Parameters.AddWithValue("@kind_code", (string)row.Cells[BillGridViewConst.KIND_CODEINDEX].Value);
                        com.Parameters.AddWithValue("@remarks", (string)row.Cells[BillGridViewConst.REMARKSINDEX].Value);
                        com.Parameters.AddWithValue("@num", UtilString.comaDel((string)row.Cells[BillGridViewConst.NUMINDEX].Value));

                        com.Parameters.AddWithValue("@tema_flg", (string)row.Cells[BillGridViewConst.TEMAFLGINDEX].Value);
                        if ((string)row.Cells[BillGridViewConst.TEMAFLGINDEX].Value == "1")
                        {
                            com.Parameters.AddWithValue("@tanka", UtilString.comaDel((string)row.Cells[BillGridViewConst.TANKAINDEX].Value));
                        }
                        else
                        {
                            com.Parameters.AddWithValue("@tanka", 0);
                        }

                        if ((string)row.Cells[BillGridViewConst.RITUINDEX].Value != "")
                        {
                            com.Parameters.AddWithValue("@ritu", (string)row.Cells[BillGridViewConst.RITUINDEX].Value);
                        }
                        else
                        {
                            com.Parameters.AddWithValue("@ritu", 0);
                        }

                        com.Parameters.AddWithValue("@price", UtilString.comaDel((string)row.Cells[BillGridViewConst.PRICEINDEX].Value));

                        com.ExecuteNonQuery();
                    }

                    // コミット
                    tran.Commit();
                    saveFlag = false;
                    return true;
                }
                catch (Exception ex)
                {
                    if (tran != null)
                    {
                        tran.Rollback();
                    }
                    Console.WriteLine(ex);
                    return false;
                }
                finally
                {
                    if (tran != null)
                    {
                        tran.Dispose();
                    }
                    if (com != null)
                    {
                        com.Dispose();
                    }
                    conn.Close();
                    conn.Dispose();
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        /////////////////////////////////////////////////////
        // 品名コードの存在チェック
        /////////////////////////////////////////////////////
        private bool checkHinmeiCode(string companyCode, string hinmeiCode, ref string hinmeiName)
        {
            using (SqlConnection conn = new SqlConnection(BillFormConst.CONNECT))
            {
                SqlCommand com = null;
                try
                {
                    conn.Open();
                    com = new SqlCommand();
                    com.Connection = conn;

                    ////////////////////////////////////////////////////
                    // コードの存在チェックを行う
                    ////////////////////////////////////////////////////
                    com.CommandText = "SELECT NAME FROM TBLM_HINMEI WHERE COMPANY_CODE=@company_code AND CODE=@code";
                    com.Parameters.AddWithValue("@company_code", companyCode);
                    com.Parameters.AddWithValue("@code", hinmeiCode);

                    SqlDataReader cReader = com.ExecuteReader();

                    while (cReader.Read())
                    {
                        if (cReader[0].ToString() != "")
                        {
                            hinmeiName = cReader[0].ToString();
                            cReader.Close();
                            return true;
                        }
                    }
                    cReader.Close();
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("存在チェックに失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex);
                    return false;
                }
                finally
                {
                    if (com != null)
                    {
                        com.Dispose();
                    }
                    conn.Close();
                    conn.Dispose();
                }
            }
        }


        /////////////////////////////////////////////////////
        // 合計の再計算
        /////////////////////////////////////////////////////
        private void calcSumPrice()
        {
            // 合計の再計算
            double sum_price = 0;
            foreach (DataGridViewRow row in gridViewBill.Rows)
            {
                sum_price += double.Parse(UtilString.comaDel((string)row.Cells[BillGridViewConst.PRICEINDEX].Value));
            }
            StringBuilder buf = new StringBuilder();
            buf.Append("\\");
            buf.Append(String.Format("{0:n0}",sum_price));
            labelSumPrice.Text = buf.ToString();
        }

        /////////////////////////////////////////////////////
        // 選択モードのテキスト変更
        /////////////////////////////////////////////////////
        private void modeTextChange()
        {
            switch (instupdflag)
            {
                case ModoConst.DEL:
                    labelMode.Text = "削除";
                    break;
                case ModoConst.UPD:
                    labelMode.Text = "修正";
                    break;
                case ModoConst.ADD:
                    labelMode.Text = "追加";
                    break;
                default:
                    labelMode.Text = "";
                    break;
            }
        }

        /////////////////////////////////////////////////////
        // 移動UP
        /////////////////////////////////////////////////////
        private void btnUp_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gridViewBill.SelectedRows)
            {
                if (row.Index == 0)
                {
                    return;
                }

                moveRows(row, row.Index - 1);
            }
        }

        /////////////////////////////////////////////////////
        // 移動Down
        /////////////////////////////////////////////////////
        private void btnDown_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gridViewBill.SelectedRows)
            {
                // 最後の行の場合
                if (row.Index == gridViewBill.Rows.Count - 1)
                {
                    return;
                }

                moveRows(row, row.Index + 1);
            }
        }

        /////////////////////////////////////////////////////
        // 移動
        /////////////////////////////////////////////////////
        private void moveRows(DataGridViewRow row, int index)
        {
            object[] param = new object[BillGridViewConst.GRIDINDEXNUM];
            for (int i = 0; i < BillGridViewConst.GRIDINDEXNUM; i++)
            {
                param[i] = row.Cells[i].Value;
            }

            DataGridViewRow row2 = gridViewBill.Rows[index];
            object[] param2 = new object[BillGridViewConst.GRIDINDEXNUM];
            for (int i = 0; i < BillGridViewConst.GRIDINDEXNUM; i++)
            {
                param2[i] = row2.Cells[i].Value;
            }

            for (int i = 0; i < BillGridViewConst.GRIDINDEXNUM; i++)
            {
                row.Cells[i].Value = param2[i];
            }

            for (int i = 0; i < BillGridViewConst.GRIDINDEXNUM; i++)
            {
                row2.Cells[i].Value = param[i];
            }

            row.Selected = false;
            row2.Selected = true;
        }

        private void textNum_Enter(object sender, EventArgs e)
        {
            textNum.SelectAll();
        }

        /////////////////////////////////////////////////////
        // 手間代変更時
        /////////////////////////////////////////////////////
        private void textTema_TextChanged(object sender, EventArgs e)
        {
            if (textTema.Text != "")
            {
                if (!checkString.IsNumber(textTema.Text))
                {
                    textTema.Text = "0";
                    MessageBox.Show("数字のみを入力して下さい。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        /////////////////////////////////////////////////////
        // コード検索ボタン押下時
        /////////////////////////////////////////////////////
        private void btnHinmeiSearch_Click(object sender, EventArgs e)
        {
            if (textCompanyCode.Text == "")
            {
                MessageBox.Show("会社コードを入力して下さい。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // コード検索画面をモーダル表示
            HinmeiSearchForm form = new HinmeiSearchForm();
            form.companyCode = textCompanyCode.Text;
            form.searchValue = textCode.Text;
            form.BackColor = Color.PowderBlue;
            form.ShowDialog(this);
            if (form.selectFlg)
            {
                this.textCode.Text = form.selectCode;
                this.labelHinmei.Text = form.selectHinmei;
            }
        }

        /////////////////////////////////////////////////////
        // 会社コード検索ボタン押下時
        /////////////////////////////////////////////////////
        private void btnCompanySearch_Click(object sender, EventArgs e)
        {
            CompanySearchForm form = new CompanySearchForm();
//            form.searchValue = textCompanyCode.Text;
            form.searchValue = "";
            form.BackColor = Color.PowderBlue;
            form.ShowDialog(this);
            if (form.selectFlg)
            {
                if (this.textCompanyCode.Text != form.selectCode)
                {
                    //品名コードをクリア
                    this.textCode.Text = "";
                    this.labelHinmei.Text = "";
                }
                this.textCompanyCode.Text = form.selectCode;
                this.labelCompany.Text = form.selectName;
            }
        }

        private void btnRemarksClear_Click(object sender, EventArgs e)
        {
            textRemarks.Text = "";
        }

        private void btnNumClear_Click(object sender, EventArgs e)
        {
            textNum.Text = "";
            textNum.Select();
        }

        private void btnTemaClear_Click(object sender, EventArgs e)
        {
            textTema.Text = "";
            textTema.Select();
        }

        private void btnTankaClear_Click(object sender, EventArgs e)
        {
            textTanka.Text = "";
            textTanka.Select();
        }

        private void btnRituClear_Click(object sender, EventArgs e)
        {
            textRitu.Text = "";
            textRitu.Select();
        }

        private void checkSounyu_CheckedChanged(object sender, EventArgs e)
        {
            if(checkSounyu.Checked == true)
            {
                numericUpDownLine.Enabled = true;
                numericUpDownLine.Select();
            }
            else{
                numericUpDownLine.Enabled = false;
            }
        }

        private void boxKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            textNum.Select();
        }

        private void timerMsg_Tick(object sender, EventArgs e)
        {
            labelHaneiMsg.Visible = false;
            timerMsg.Stop();
        }

        private void btnSanshow_Click(object sender, EventArgs e)
        {
            if (this.textCode.Text == "")
            {
                MessageBox.Show("品名コードを入力して下さい。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 品名参照画面をモーダル表示
            HinmeiTankaForm form = new HinmeiTankaForm();
            form.companyCode = textCompanyCode.Text;
            form.hinmeiCode = textCode.Text;
            form.hinmeiName = labelCompany.Text + "   " + labelHinmei.Text;
            form.year = gYear;
            form.month = gMonth;
            form.ShowDialog(this);
        }

        private void btnAtode_Click(object sender, EventArgs e)
        {
            textRemarks.Text = BillFormConst.AFTERREMARK;
        }
    }
}
