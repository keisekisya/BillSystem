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
    public partial class AddressForm : Form
    {
        public AddressForm()
        {
            InitializeComponent();
        }

        //////////////////////////////////////////////
        // 画面ロード時
        //////////////////////////////////////////////
        private void AddressForm_Load(object sender, EventArgs e)
        {
            AddressInfo adrInfo = new AddressInfo();
            if (DbAccessFunc.getAddressInfo(ref adrInfo))
            {
                textToName.Text = adrInfo.to_name;
                textFromName.Text = adrInfo.from_name;
                textFromAddress1.Text = adrInfo.from_address1;
                textFromAddress2.Text = adrInfo.from_address2;
                textFromTel.Text = adrInfo.from_tel;
                textFromInvoice.Text = adrInfo.from_invoice_no;
            }
            btnClose.Select();
        }

        //////////////////////////////////////////////
        // 保存ボタン押下時
        //////////////////////////////////////////////
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(BillFormConst.CONNECT))
            {
                SqlTransaction tran = null;
                SqlCommand com = null;
                try
                {
                    // マウスを砂時計に
                    Cursor.Current = Cursors.WaitCursor;

                    conn.Open();
                    com = conn.CreateCommand();
                    com.Connection = conn;

                    ////////////////////////////////////////////////////
                    // コードの存在チェックを行う
                    ////////////////////////////////////////////////////
                    com.CommandText = "SELECT COUNT(*) FROM TBLM_ADDRESS WHERE UPKEY='1'";

                    SqlDataReader cReader = com.ExecuteReader();

                    bool insertFlg = true;
                    while (cReader.Read())
                    {
                        if (cReader[0].ToString() == "0")
                        {
                            insertFlg = true;
                        }
                        else
                        {
                            insertFlg = false;
                        }
                        break;
                    }
                    cReader.Close();

                    // トランザクション開始
                    tran = conn.BeginTransaction();
                    com.Transaction = tran;

                    ////////////////////////////////////////////////////
                    // データの登録を行う
                    ////////////////////////////////////////////////////
                    if (insertFlg)
                    {
                        com.CommandText = "INSERT INTO TBLM_ADDRESS(UPKEY,TO_NAME,FROM_NAME,FROM_ADDRESS_1,FROM_ADDRESS_2,FROM_TEL,FROM_INVOICE_NO) values('1',@to_name,@from_name,@from_address_1,@from_address_2,@from_tel,@from_invoice_no)";
                    }
                    else
                    {
                        com.CommandText = "UPDATE TBLM_ADDRESS SET TO_NAME = @to_name,FROM_NAME = @from_name,FROM_ADDRESS_1 = @from_address_1,FROM_ADDRESS_2 = @from_address_2,FROM_TEL = @from_tel, FROM_INVOICE_NO = @from_invoice_no  WHERE UPKEY='1'";
                    }

                    com.Parameters.AddWithValue("@to_name", textToName.Text);
                    com.Parameters.AddWithValue("@from_name", textFromName.Text);
                    com.Parameters.AddWithValue("@from_address_1", textFromAddress1.Text);
                    com.Parameters.AddWithValue("@from_address_2", textFromAddress2.Text);
                    com.Parameters.AddWithValue("@from_tel", textFromTel.Text);
                    com.Parameters.AddWithValue("@from_invoice_no", textFromInvoice.Text);
                    
                    com.ExecuteNonQuery();

                    // コミット
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    if (tran != null)
                    {
                        tran.Rollback();
                    }
                    MessageBox.Show("保存に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex);
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
                    this.Close();
                }
            }
        }

        //////////////////////////////////////////////
        // 閉じるボタン押下時
        //////////////////////////////////////////////
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
