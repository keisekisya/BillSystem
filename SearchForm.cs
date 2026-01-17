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
    public partial class SearchForm : Form
    {
        private Dictionary<string, string> kindTable;

        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            // 行の高さを設定
            gridViewBill.RowTemplate.Height = 36;

            // フォントを設定
            gridViewBill.Font = new System.Drawing.Font("MS UI Gothic", 13.80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));

            // 年コンボボックスの設定
            int minYear = 0;
            int maxYear = 0;
            if (getYear(ref minYear, ref maxYear) == false)
            {
                MessageBox.Show("最小最大年取得失敗", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            for (int i = minYear; i <= maxYear; i++)
            {
                boxYear.Items.Add(i);
            }
            boxYear.Text = minYear.ToString();

            // 月コンボボックスの設定
            for (int i = 1; i <= 12; i++)
            {
                boxMonth.Items.Add(String.Format("{0:D2}", i));
            }
            boxMonth.Text = "01";

            if (getKindList() == false)
            {
                MessageBox.Show("種類取得失敗", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            this.labelSelCompanyName.Text = "";
            this.labelCompanyName.Text = "";
            this.labelHinmei.Text = "";
            groupSelCompany.Enabled = false;
            groupYear.Enabled = false;
            groupMonth.Enabled = false;
            groupComHinmeiCode.Enabled = false;
            groupKind.Enabled = false;
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (checkYear.Checked == false &&
               checkMonth.Checked == false &&
               checkSelCompany.Checked == false &&
               checkComHinmeiCode.Checked == false &&
               checkKind.Checked == false)
            {
                MessageBox.Show("最低１つにチェックを付けて下さい。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (checkComHinmeiCode.Checked == true)
            {
                if (textCompanyCode.Text == "")
                {
                    MessageBox.Show("会社コードを入力して下さい。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            search_func();
        }

        private void search_func()
        {
            // DBよりデータを取得
            using (SqlConnection conn = new SqlConnection(BillFormConst.CONNECT))
            {
                SqlCommand com = null;

                try
                {
                    conn.Open();

                    com = conn.CreateCommand();
                    com.Connection = conn;

                    StringBuilder sqlbuf = new StringBuilder();
                    sqlbuf.Append("SELECT B.NAME AS SELNAME,A.YEAR, A.MONTH, A.DAY, A.SHOW_NUM, C.NAME AS COMPANY_NAME, D.NAME AS HINMEI_NAME, E.NAME AS KIND_NAME, A.REMARKS, A.NUM, A.TANKA, A.PRICE, A.RITU, A.TEMA_FLG ");
                    sqlbuf.Append("FROM ((((TBLT_PRICE A ");
                    sqlbuf.Append("LEFT OUTER JOIN TBLM_COMPANY B ON A.KEY_COMPANY_CODE = B.CODE) ");
                    sqlbuf.Append("INNER JOIN  TBLM_COMPANY C ON A.COMPANY_CODE = C.CODE) ");
                    sqlbuf.Append("INNER JOIN TBLM_HINMEI D ON A.HINMEI_CODE = D.CODE AND A.COMPANY_CODE = D.COMPANY_CODE) ");
                    sqlbuf.Append("LEFT OUTER JOIN TBLM_KIND E ON A.KIND_CODE = E.CODE) ");
                    sqlbuf.Append("WHERE ");

                    bool flag = false;
                    // 年
                    if (checkYear.Checked == true)
                    {
                        if (flag == true)
                        {
                            sqlbuf.Append(" AND ");
                        }
                        sqlbuf.Append(" A.YEAR = @year ");
                        com.Parameters.AddWithValue("@year", boxYear.Text);
                        flag = true;
                    }
                    // 月
                    if (checkMonth.Checked == true)
                    {
                        if (flag == true)
                        {
                            sqlbuf.Append(" AND ");
                        }
                        sqlbuf.Append(" A.MONTH = @month ");
                        com.Parameters.AddWithValue("@month", boxMonth.Text);
                        flag = true;
                    }
                    // 請求書会社コード
                    if (checkSelCompany.Checked == true)
                    {
                        if (flag == true)
                        {
                            sqlbuf.Append(" AND ");
                        }
                        sqlbuf.Append(" A.KEY_COMPANY_CODE = @key_company_code ");
                        com.Parameters.AddWithValue("@key_company_code", textSelCompanyCode.Text);
                        flag = true;
                    }
                    // 会社、品名コード
                    if (checkComHinmeiCode.Checked == true)
                    {
                        if (flag == true)
                        {
                            sqlbuf.Append(" AND ");
                        }
                        sqlbuf.Append(" A.COMPANY_CODE = @company_code ");
                        com.Parameters.AddWithValue("@company_code", textCompanyCode.Text);

                        if (textHinmeiCode.Text != "")
                        {
                            sqlbuf.Append(" AND ");
                            sqlbuf.Append(" A.HINMEI_CODE = @hinmei_code ");
                            com.Parameters.AddWithValue("@hinmei_code", textHinmeiCode.Text);
                        }
                        flag = true;
                    }
                    // 種類
                    if (checkKind.Checked == true)
                    {
                        if (flag == true)
                        {
                            sqlbuf.Append(" AND ");
                        }
                        sqlbuf.Append(" A.KIND_CODE = @kind_code ");
                        com.Parameters.AddWithValue("@kind_code", kindTable[boxKind.Text]);
                        flag = true;
                    }

                    sqlbuf.Append("ORDER BY A.YEAR, A.MONTH, A.KEY_COMPANY_CODE, A.SHOW_NUM, A.DAY, A.COMPANY_CODE ");
                    com.CommandText = sqlbuf.ToString();

                    SqlDataReader cReader = com.ExecuteReader();

                    gridViewBill.Rows.Clear();
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

                        gridViewBill.Rows.Add(cReader["YEAR"].ToString(),
                                              cReader["MONTH"].ToString(),
                                              cReader["SELNAME"].ToString(),
                                              int.Parse(cReader["SHOW_NUM"].ToString()) + 1,
                                              cReader["DAY"].ToString(),
                                              cReader["COMPANY_NAME"].ToString(),
                                              cReader["HINMEI_NAME"].ToString(),
                                              cReader["KIND_NAME"].ToString(),
                                              String.Format("{0:n0}", double.Parse(UtilString.syousuutennDel(cReader["NUM"].ToString()))),
                                              tanka,
                                              String.Format("{0:n0}", double.Parse(UtilString.syousuutennDel(cReader["PRICE"].ToString()))),
                                              ritu,
                                              cReader["REMARKS"].ToString());
                    }
                    cReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DBエラー", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex);
                    throw ex;
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

        ///////////////////////////////////////////////////////
        // 最少登録年を取得
        ///////////////////////////////////////////////////////
        private bool getYear(ref int minYear, ref int maxYear)
        {
            // DBよりデータを取得
            using (SqlConnection conn = new SqlConnection(BillFormConst.CONNECT))
            {
                SqlCommand com = null;

                try
                {
                    conn.Open();

                    com = new SqlCommand("SELECT MIN(YEAR), MAX(YEAR) FROM TBLT_PRICE");
                    com.Connection = conn;
                    SqlDataReader cReader = com.ExecuteReader();

                    while (cReader.Read())
                    {
                        if (cReader[0].ToString() != "")
                        {
                            minYear = int.Parse(cReader[0].ToString());
                            maxYear = int.Parse(cReader[1].ToString());
                        }
                    }
                    cReader.Close();
                    return true;
                }
                catch (Exception ex)
                {
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

        ///////////////////////////////////////////////////////
        // 種類を取得
        ///////////////////////////////////////////////////////
        private bool getKindList()
        {
            // DBよりデータを取得
            using (SqlConnection conn = new SqlConnection(BillFormConst.CONNECT))
            {
                SqlCommand com = null;

                try
                {
                    kindTable = new Dictionary<string, string>();

                    conn.Open();

                    com = new SqlCommand("SELECT CODE, NAME FROM TBLM_KIND WHERE DEL_FLG <> '1' ORDER BY CODE");
                    com.Connection = conn;
                    SqlDataReader cReader = com.ExecuteReader();

                    Graphics g = boxKind.CreateGraphics();
                    Font f = boxKind.Font;
                    float maxWith = 0;
                    boxKind.Items.Add("");
                    kindTable.Add("", "");
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
                    return true;
                }
                catch (Exception ex)
                {
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkSelCompany_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSelCompany.Checked == true)
            {
                groupSelCompany.Enabled = true;
            }
            else
            {
                groupSelCompany.Enabled = false;
            }
        }

        private void checkYear_CheckedChanged(object sender, EventArgs e)
        {
            if (checkYear.Checked == true)
            {
                groupYear.Enabled = true;
            }
            else
            {
                groupYear.Enabled = false;
            }
        }

        private void checkMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMonth.Checked == true)
            {
                groupMonth.Enabled = true;
            }
            else
            {
                groupMonth.Enabled = false;
            }
        }

        private void checkComHinmeiCode_CheckedChanged(object sender, EventArgs e)
        {
            if (checkComHinmeiCode.Checked == true)
            {
                groupComHinmeiCode.Enabled = true;
            }
            else
            {
                groupComHinmeiCode.Enabled = false;
            }
        }

        private void checkKind_CheckedChanged(object sender, EventArgs e)
        {
            if (checkKind.Checked == true)
            {
                groupKind.Enabled = true;
            }
            else
            {
                groupKind.Enabled = false;
            }
        }

        private void btnCompanyFormUp_Click(object sender, EventArgs e)
        {
            CompanySearchForm form = new CompanySearchForm();
            form.searchValue = "";
            form.BackColor = groupSelCompany.BackColor;
            form.ShowDialog(this);
            if (form.selectFlg)
            {
                this.textSelCompanyCode.Text = form.selectCode;
                this.labelSelCompanyName.Text = form.selectName;
            }
        }

        private void btnCodeClear_Click(object sender, EventArgs e)
        {
            textSelCompanyCode.Text = "";
            labelSelCompanyName.Text = "";
        }

        private void btnCompanyFormUp2_Click(object sender, EventArgs e)
        {
            CompanySearchForm form = new CompanySearchForm();
            form.searchValue = "";
            form.BackColor = groupComHinmeiCode.BackColor;
            form.ShowDialog(this);
            if (form.selectFlg)
            {
                this.textCompanyCode.Text = form.selectCode;
                this.labelCompanyName.Text = form.selectName;
            }
        }

        private void btnCodeClear2_Click(object sender, EventArgs e)
        {
            this.textCompanyCode.Text = "";
            this.labelCompanyName.Text = "";
            this.textHinmeiCode.Text = "";
            this.labelHinmei.Text = "";
        }

        private void btnHinmeiFormUp_Click(object sender, EventArgs e)
        {
            if (textCompanyCode.Text == "")
            {
                MessageBox.Show("会社コードを入力して下さい。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // コード検索画面をモーダル表示
            HinmeiSearchForm form = new HinmeiSearchForm();
            form.companyCode = textCompanyCode.Text;
            form.searchValue = textHinmeiCode.Text;
            form.BackColor = groupComHinmeiCode.BackColor;
            form.ShowDialog(this);
            if (form.selectFlg)
            {
                this.textHinmeiCode.Text = form.selectCode;
                this.labelHinmei.Text = form.selectHinmei;
            }

        }

        private void btnCodeClear3_Click(object sender, EventArgs e)
        {
            this.textHinmeiCode.Text = "";
            this.labelHinmei.Text = "";
        }
    }
}
