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
    public partial class CompanySearchForm : Form
    {
        public string searchValue { get; set; }

        public bool selectFlg { get; set; }
        public string selectCode { get; set; }
        public string selectName { get; set; }

        public CompanySearchForm()
        {
            InitializeComponent();
        }

        /////////////////////////////////////////////////////
        // フォームロード時
        /////////////////////////////////////////////////////
        private void CompanySearchForm_Load(object sender, EventArgs e)
        {
            // 行の高さを設定
            gridViewCompanySearch.RowTemplate.Height = 36;

            // フォントを設定
            gridViewCompanySearch.Font = new System.Drawing.Font("MS UI Gothic", 13.80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));

            // コードを選択状態にする
            radioCode.Checked = true;

            if (searchValue.Length != 0)
            {
                search_func(searchValue, 1);
                this.textSearch.Text = searchValue;
            }
            else
            {
                search_func("", 3);
            }
            selectFlg = false;

            textSearch.Select();
        }

        /////////////////////////////////////////////////////
        // グリッド行番号を表示
        /////////////////////////////////////////////////////
        private void gridViewCompanySearch_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // 行ヘッダのセル領域を、行番号を描画する長方形とする
            // （ただし右端に4ドットのすき間を空ける）
            Rectangle rect = new Rectangle(e.RowBounds.Location.X,
                                           e.RowBounds.Location.Y,
                                           gridViewCompanySearch.RowHeadersWidth - 4,
                                           e.RowBounds.Height);

            // 上記の長方形内に行番号を縦方向中央＆右詰めで描画する
            // フォントや前景色は行ヘッダの既定値を使用する
            TextRenderer.DrawText(e.Graphics,
                                  (e.RowIndex + 1).ToString(),
                                  gridViewCompanySearch.RowHeadersDefaultCellStyle.Font,
                                  rect,
                                  gridViewCompanySearch.RowHeadersDefaultCellStyle.ForeColor,
                                  TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /////////////////////////////////////////////////////
        // 閉じるボタン押下時
        /////////////////////////////////////////////////////
        private void btnCancel_Click(object sender, EventArgs e)
        {
            selectFlg = false;
            this.Close();
        }

        /////////////////////////////////////////////////////
        // 選択ボタン押下時
        /////////////////////////////////////////////////////
        private void btnOK_Click(object sender, EventArgs e)
        {
            selectGrid();
        }

        /////////////////////////////////////////////////////
        // セルダブルクリック時
        /////////////////////////////////////////////////////
        private void gridViewCompanySearch_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectGrid();
        }

        /////////////////////////////////////////////////////
        // 選択処理
        /////////////////////////////////////////////////////
        private void selectGrid()
        {
            DataGridViewRow row = gridViewCompanySearch.CurrentRow;
            if (row == null)
            {
                MessageBox.Show("行を選択して下さい。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            selectCode = (string)row.Cells[0].Value;
            selectName = (string)row.Cells[1].Value;
            selectFlg = true;
            this.Close();
        }

        /////////////////////////////////////////////////////
        // 検索ボタン押下時
        /////////////////////////////////////////////////////
        private void btnSearch_Click(object sender, EventArgs e)
        {
            search_com();
        }

        /////////////////////////////////////////////////////
        // 検索文字変更時
        /////////////////////////////////////////////////////
        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            search_com();
        }

        /////////////////////////////////////////////////////
        // 検索処理
        /////////////////////////////////////////////////////
        private void search_com()
        {
            int flag = 0;
            if (radioCode.Checked == true)
            {
                flag = 1;
            }
            else if (radioName.Checked == true)
            {
                flag = 2;
            }
            else
            {
                MessageBox.Show("コードか会社名を選択して下さい。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            search_func(textSearch.Text, flag);
        }

        /////////////////////////////////////////////////////
        // 検索処理
        /////////////////////////////////////////////////////
        private void search_func(string paramValue, int serachFlg)
        {
            // DBよりデータを取得
            using (SqlConnection conn = new SqlConnection(BillFormConst.CONNECT))
            {
                SqlCommand com = null;

                try
                {
                    conn.Open();

                    com = conn.CreateCommand();
                    StringBuilder sqlbuf = new StringBuilder();
                    sqlbuf.Append("SELECT CODE,NAME FROM TBLM_COMPANY WHERE DEL_FLG <> '1' ");

                    switch (serachFlg)
                    {
                        case 1:
                            sqlbuf.Append(" AND CODE LIKE @code ORDER BY CODE");
                            com.Parameters.AddWithValue("@code", paramValue + "%");
                            break;
                        case 2:
                            sqlbuf.Append(" AND NAME LIKE @name ORDER BY CODE");
                            com.Parameters.AddWithValue("@name", "%" + paramValue + "%");
                            break;
                        default:
                            sqlbuf.Append(" ORDER BY CODE");
                            break;
                    }
                    com.CommandText = sqlbuf.ToString();
                    com.Connection = conn;
                    SqlDataReader cReader = com.ExecuteReader();

                    gridViewCompanySearch.Rows.Clear();
                    while (cReader.Read())
                    {
                        gridViewCompanySearch.Rows.Add(cReader[0].ToString(),
                                               cReader[1].ToString());
                    }
                    cReader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
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

        private void btnSearchClear_Click(object sender, EventArgs e)
        {
            textSearch.Text = "";
            textSearch.Select();
        }

        private void textSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ESC押下時
            if (e.KeyChar == 27)
            {
                selectGrid();
            }
        }

        private void gridViewCompanySearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ESC押下時
            if (e.KeyChar == 27)
            {
                selectGrid();
            }
        }

        private void CompanySearchForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ESC押下時
            if (e.KeyChar == 27)
            {
                selectGrid();
            }
        }
    }
}
