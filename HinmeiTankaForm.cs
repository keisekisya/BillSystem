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
    public partial class HinmeiTankaForm : Form
    {
        public string companyCode { get; set; }
        public string hinmeiCode { get; set; }
        public string hinmeiName { get; set; }
        public string year { get; set; }
        public string month { get; set; }

        public HinmeiTankaForm()
        {
            InitializeComponent();
        }

        /////////////////////////////////////////////////////
        // フォームロード時
        /////////////////////////////////////////////////////
        private void HinmeiTankaForm_Load(object sender, EventArgs e)
        {
            // 行の高さを設定
            gridViewHinmei.RowTemplate.Height = 36;

            // フォントを設定
            gridViewHinmei.Font = new System.Drawing.Font("MS UI Gothic", 13.80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));

            labelName.Text = hinmeiName;
            search_func();
            btnCancel.Select();
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
                                           gridViewHinmei.RowHeadersWidth - 4,
                                           e.RowBounds.Height);

            // 上記の長方形内に行番号を縦方向中央＆右詰めで描画する
            // フォントや前景色は行ヘッダの既定値を使用する
            TextRenderer.DrawText(e.Graphics,
                                  (e.RowIndex + 1).ToString(),
                                  gridViewHinmei.RowHeadersDefaultCellStyle.Font,
                                  rect,
                                  gridViewHinmei.RowHeadersDefaultCellStyle.ForeColor,
                                  TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /////////////////////////////////////////////////////
        // 閉じるボタン押下時
        /////////////////////////////////////////////////////
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /////////////////////////////////////////////////////
        // 検索処理
        /////////////////////////////////////////////////////
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
                    StringBuilder sqlbuf = new StringBuilder();
                    sqlbuf.Append("SELECT TOP 100 A.YEAR,A.MONTH,B.NAME KIND,A.NUM,A.TANKA,A.PRICE,A.TEMA_FLG ");
                    sqlbuf.Append(" FROM (TBLT_PRICE A ");
                    sqlbuf.Append(" LEFT OUTER JOIN TBLM_KIND B ON A.KIND_CODE = B.CODE) ");
                    sqlbuf.Append(" WHERE A.COMPANY_CODE = @company_code ");
                    sqlbuf.Append("   AND A.HINMEI_CODE = @hinmei_code ");
                    sqlbuf.Append(" ORDER BY A.YEAR DESC, A.MONTH DESC");

                    com.Parameters.AddWithValue("@company_code", companyCode);
                    com.Parameters.AddWithValue("@hinmei_code", hinmeiCode);

                    com.CommandText = sqlbuf.ToString();
                    com.Connection = conn;
                    SqlDataReader cReader = com.ExecuteReader();

                    int index = 0;
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

                        gridViewHinmei.Rows.Add(cReader["YEAR"].ToString(),
                                                cReader["MONTH"].ToString(),
                                                cReader["KIND"].ToString(),
                                                String.Format("{0:n0}", double.Parse(UtilString.syousuutennDel(cReader["NUM"].ToString()))),
                                                tanka,
                                                String.Format("{0:n0}", double.Parse(UtilString.syousuutennDel(cReader["PRICE"].ToString())))
                                                );

                        // 同年月のデータの場合
                        if (cReader["YEAR"].ToString() == year &&
                           cReader["MONTH"].ToString() == month)
                        {
                            DataGridViewRow row = gridViewHinmei.Rows[index];
                            row.DefaultCellStyle.BackColor = Color.BurlyWood;
                        }

                        index++;
                    }

                    if (gridViewHinmei.RowCount > 0)
                    {
                        DataGridViewRow row = gridViewHinmei.Rows[0];
                        row.Selected = false;
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

        private void HinmeiTankaForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ESC押下時
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
    }
}
