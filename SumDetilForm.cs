using System;
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
    public partial class SumDetilForm : Form
    {
        public string gYear { get; set; }
        public string gMonth { get; set; }

        public SumDetilForm()
        {
            InitializeComponent();
        }

        private void SumDetilForm_Load(object sender, EventArgs e)
        {
            // 行の高さを設定
            gridViewDetil.RowTemplate.Height = 36;

            // フォントを設定
            gridViewDetil.Font = new System.Drawing.Font("MS UI Gothic", 13.80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));

            // DBよりデータを取得
            search_func();
        }

        /////////////////////////////////////////////////////
        // グリッド行番号を表示
        /////////////////////////////////////////////////////
        private void gridViewHinmei_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // 行ヘッダのセル領域を、行番号を描画する長方形とする
            // （ただし右端に4ドットのすき間を空ける）
            Rectangle rect = new Rectangle(e.RowBounds.Location.X,
                                           e.RowBounds.Location.Y,
                                           gridViewDetil.RowHeadersWidth - 4,
                                           e.RowBounds.Height);

            // 上記の長方形内に行番号を縦方向中央＆右詰めで描画する
            // フォントや前景色は行ヘッダの既定値を使用する
            TextRenderer.DrawText(e.Graphics,
                                  (e.RowIndex + 1).ToString(),
                                  gridViewDetil.RowHeadersDefaultCellStyle.Font,
                                  rect,
                                  gridViewDetil.RowHeadersDefaultCellStyle.ForeColor,
                                  TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /////////////////////////////////////////////////////
        // 検索処理
        /////////////////////////////////////////////////////
        private void search_func()
        {
            labelYear.Text = gYear;
            labelMonth.Text = gMonth;

            // DBよりデータを取得
            using (SqlConnection conn = new SqlConnection(BillFormConst.CONNECT))
            {
                SqlCommand com = null;

                try
                {
                    StringBuilder sqlbuf = new StringBuilder();
                    sqlbuf.Append("SELECT B.NAME,COUNT(*),SUM(A.PRICE) ");
                    sqlbuf.Append("FROM TBLT_PRICE A ");
                    sqlbuf.Append("LEFT OUTER JOIN TBLM_COMPANY B ON A.KEY_COMPANY_CODE = B.CODE ");
                    sqlbuf.Append("WHERE A.YEAR = @year AND A.MONTH = @month ");
                    sqlbuf.Append("GROUP BY B.NAME ");
                    //sqlbuf.Append("ORDER BY B.NAME ");
                    sqlbuf.Append("UNION ALL ");
                    sqlbuf.Append("SELECT REMARKS,0,PRICE ");
                    sqlbuf.Append("FROM TBLT_EXCEPTION_PRICE ");
                    sqlbuf.Append("WHERE YEAR = @year AND MONTH = @month ");
                    //sqlbuf.Append("ORDER BY LINE ");

                    conn.Open();
                    com = new SqlCommand(sqlbuf.ToString());
                    com.Connection = conn;

                    com.Parameters.AddWithValue("@year", gYear);
                    com.Parameters.AddWithValue("@month", gMonth);
                    SqlDataReader cReader = com.ExecuteReader();

                    long sum = 0;
                    while (cReader.Read())
                    {
                        long tmpPrice = long.Parse(cReader[2].ToString());
                        gridViewDetil.Rows.Add(cReader[0].ToString(),
                                               cReader[1].ToString(),
                                               String.Format("{0:n0}", tmpPrice));
                        sum+= tmpPrice;
                    }
                    cReader.Close();
                    StringBuilder tmpSum = new StringBuilder();
                    tmpSum.Append("\\");
                    tmpSum.Append(String.Format("{0:n0}", sum));
                    labelSumPrice.Text = tmpSum.ToString();

                    // 消費税の計算
                    double tax = global::BillSystem.Properties.Settings.Default.Tax;
                    long tmpSumTax = (long)(sum * (tax / 100));
                    labelTaxPrice.Text = "\\" + String.Format("{0:n0}", tmpSumTax);

                    // 税込合計金額
                    labelSumTaxKomiPrice.Text = "\\" + String.Format("{0:n0}", sum + tmpSumTax);

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

                    if (tmpReadOnly == "1")
                    {
                        checkReadOnly.Checked = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show("検索に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        // 閉じるボタン押下時
        /////////////////////////////////////////////////////
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /////////////////////////////////////////////////////
        // 適用ボタン押下時
        /////////////////////////////////////////////////////
        private void btnSave_Click(object sender, EventArgs e)
        {
            // DBよりデータを取得
            using (SqlConnection conn = new SqlConnection(BillFormConst.CONNECT))
            {
                SqlCommand com = null;
                SqlTransaction tran = null;

                try
                {
                    StringBuilder sqlbuf = new StringBuilder();
                    sqlbuf.Append("SELECT READONLY ");
                    sqlbuf.Append("FROM TBLT_PARAMSET ");
                    sqlbuf.Append("WHERE YEAR = @year AND MONTH = @month ");

                    conn.Open();
                    com = new SqlCommand(sqlbuf.ToString());
                    com.Connection = conn;

                    com.Parameters.AddWithValue("@year", gYear);
                    com.Parameters.AddWithValue("@month", gMonth);
                    SqlDataReader cReader = com.ExecuteReader();

                    string dataReadOnlyCheck = "";
                    Boolean dataAriFlg = false;
                    if (cReader.Read())
                    {
                        dataAriFlg = true;
                        dataReadOnlyCheck = cReader[0].ToString();
                    }
                    cReader.Close();

                    string tmpReadOnlyCheck = "";
                    if (checkReadOnly.Checked == true)
                    {
                        tmpReadOnlyCheck = "1";
                    }
                    else
                    {
                        tmpReadOnlyCheck = "0";
                    }

                    // データがない場合
                    if (dataAriFlg == false)
                    {
                        // トランザクション開始
                        tran = conn.BeginTransaction();
                        com.Transaction = tran;

                        com.CommandText = "INSERT INTO TBLT_PARAMSET(YEAR,MONTH,READONLY) values(@year,@month,@readonly)";
                        com.Parameters.AddWithValue("@readonly", tmpReadOnlyCheck);

                        com.ExecuteNonQuery();
                        // コミット
                        tran.Commit();
                    }
                    else
                    {
                        // 値が変わっていない場合は更新しない。
                        if (dataReadOnlyCheck == tmpReadOnlyCheck)
                        {
                            return;
                        }

                        // トランザクション開始
                        tran = conn.BeginTransaction();
                        com.Transaction = tran;

                        com.CommandText = "UPDATE TBLT_PARAMSET SET READONLY = @readonly WHERE YEAR = @year AND MONTH = @month";
                        com.Parameters.AddWithValue("@readonly", tmpReadOnlyCheck);

                        com.ExecuteNonQuery();
                        // コミット
                        tran.Commit();
                    }
                }
                catch (Exception ex)
                {
                    if (tran != null)
                    {
                        tran.Rollback();
                    }
                    Console.WriteLine(ex);
                    MessageBox.Show("適用に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                }
            }
        }
    }
}
