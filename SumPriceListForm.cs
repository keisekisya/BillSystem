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
    public partial class SumPriceListForm : Form
    {
        private string gYear;
        private string gMonth;

        public SumPriceListForm()
        {
            InitializeComponent();
        }

        ///////////////////////////////////////////
        // 画面起動時
        ///////////////////////////////////////////
        private void SumPriceListForm_Load(object sender, EventArgs e)
        {
            /////////////////////////////////////////////////////////
            // グリッドの設定
            /////////////////////////////////////////////////////////

            // 行の高さを設定
            gridSumPriceList.RowTemplate.Height = 36;

            // フォントを設定
            gridSumPriceList.Font = new System.Drawing.Font("MS UI Gothic", 13.80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));

            btnClose.Select();

            /////////////////////////////////////////////////////////
            // グリッドにデータを設定
            /////////////////////////////////////////////////////////

            // DBよりデータを取得
            using (SqlConnection conn = new SqlConnection(BillFormConst.CONNECT))
            {
                SqlCommand com = null;
                try
                {
                    conn.Open();

                    StringBuilder sqlbuf = new StringBuilder();
                    sqlbuf.Append("SELECT A.YEAR,A.MONTH,SUM(A.PRICE) + ISNULL(B.SPRICE,0) ");
                    sqlbuf.Append("FROM TBLT_PRICE A ");
                    sqlbuf.Append("LEFT OUTER JOIN View_EXCEPTION_PRICE B ON A.YEAR = B.YEAR AND A.MONTH = B.MONTH ");
                    sqlbuf.Append("GROUP BY A.YEAR, A.MONTH, B.SPRICE ORDER BY A.YEAR DESC, A.MONTH DESC ");

//                    com = new SqlCommand("SELECT YEAR,MONTH,SUM(PRICE) FROM TBLT_PRICE GROUP BY YEAR, MONTH ORDER BY YEAR DESC, MONTH DESC");
                    com = new SqlCommand(sqlbuf.ToString());
                    com.Connection = conn;

                    SqlDataReader cReader = com.ExecuteReader();

                    // 消費税
                    double tax = global::BillSystem.Properties.Settings.Default.Tax;

                    while (cReader.Read())
                    {
                        /*
                                                long price = 0;
                                                if (cReader[3].ToString().Length != 0)
                                                {
                                                    price = long.Parse(cReader[3].ToString());
                                                }
                                                price += long.Parse(cReader[2].ToString());
                         */
                        long price = long.Parse(cReader[2].ToString());
                        long taxPrice = (long)(price * (tax / 100));
                        gridSumPriceList.Rows.Add(cReader[0].ToString(),
                                                  cReader[1].ToString(),
                                                  String.Format("{0:n0}", price),
                                                  String.Format("{0:n0}", price + taxPrice));
                    }
                    cReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DBエラー", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex);
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
            }
        }

        ///////////////////////////////////////////
        // 閉じるボタン押下時
        ///////////////////////////////////////////
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ///////////////////////////////////////////
        // 詳細ボタン押下時
        ///////////////////////////////////////////
        private void btnDetil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = gridSumPriceList.CurrentRow;
            if (row == null)
            {
                MessageBox.Show("行を選択して下さい。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SumDetilForm form = new SumDetilForm();
            form.gYear = (string)row.Cells[0].Value;
            form.gMonth = (string)row.Cells[1].Value;
            form.ShowDialog(this);
        }
    }
}
