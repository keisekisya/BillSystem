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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        ///////////////////////////////////////////////////////
        // 画面ロード時
        ///////////////////////////////////////////////////////
        private void MainForm_Load(object sender, EventArgs e)
        {
            labelName.Text = "";
            textCode.Text = "";

            //Mutexクラスの作成
            //"MyName"の部分を適当な文字列に変えてください
            System.Threading.Mutex m = new System.Threading.Mutex(false, "MyName");
            //ミューテックスの所有権を要求する
            if (m.WaitOne(0, false) == false)
            {
                //すでに起動していると判断する
                MessageBox.Show("多重起動はできません。");
                this.Close();
                return;
            }

            int minYear = 0;
            try
            {
                minYear = minSetYear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DBエラー", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex);
                this.Close();
                return;
            }
            // settingsファイルの使用
            string year = global::BillSystem.Settings1.Default.year;
            string month = global::BillSystem.Settings1.Default.month;

            // 年コンボボックスの設定
            int nowYear = int.Parse(DateTime.Now.ToString("yyyy"));
            int startYear = nowYear - 5;
            if (minYear != 0 && minYear < startYear)
            {
                startYear = minYear;
            }
            int endYear = nowYear + 5;
            for (int i = startYear; i < endYear; i++)
            {
                boxYear.Items.Add(i);
            }

            // 月コンボボックスの設定
            for (int i = 1; i <= 12; i++)
            {
                boxMonth.Items.Add(String.Format("{0:D2}", i));
            }

            int iYear = int.Parse(year);
            if (startYear <= iYear && iYear <= endYear)
            {
                boxYear.Text = year;
            }
            else
            {
                boxYear.Text = nowYear.ToString();
            }
            boxMonth.Text = month;
        }

        ///////////////////////////////////////////////////////
        // 終了ボタン押下時
        ///////////////////////////////////////////////////////
        private void btnExit_Click(object sender, EventArgs e)
        {
            String backuppath = global::BillSystem.Properties.Settings.Default.BackUpApp;
            if (System.IO.File.Exists(backuppath))
            {
                System.Diagnostics.Process p = System.Diagnostics.Process.Start(backuppath);
                p.WaitForExit();
            }
            this.Close();
        }

        ///////////////////////////////////////////////////////
        // 請求書作成ボタン押下時
        ///////////////////////////////////////////////////////
        private void btnBillCreate_Click(object sender, EventArgs e)
        {
            global::BillSystem.Settings1.Default.year = boxYear.Text;
            global::BillSystem.Settings1.Default.month = boxMonth.Text;
            global::BillSystem.Settings1.Default.Save();

            // 請求書作成画面をモーダル表示
            BillForm form = new BillForm();
            form.gYear = boxYear.Text;
            form.gMonth = boxMonth.Text;
            form.gCompanyCode = textCode.Text;
            form.gCompanyName = labelName.Text;
            form.ShowDialog(this);
        }

        ///////////////////////////////////////////////////////
        // 会社登録ボタン押下時
        ///////////////////////////////////////////////////////
        private void btnCompanyAdd_Click(object sender, EventArgs e)
        {
            // 会社登録画面をモーダル表示
            CompanyForm form = new CompanyForm();
            form.ShowDialog(this);
        }

        ///////////////////////////////////////////////////////
        // 品名登録ボタン押下時
        ///////////////////////////////////////////////////////
        private void btnHinmeiAdd_Click(object sender, EventArgs e)
        {
            // 品名登録画面をモーダル表示
            HinmeiForm form = new HinmeiForm();
            form.ShowDialog(this);
        }

        ///////////////////////////////////////////////////////
        // 最少登録年を取得
        ///////////////////////////////////////////////////////
        private int minSetYear()
        {
            // DBよりデータを取得
            using (SqlConnection conn = new SqlConnection(BillFormConst.CONNECT))
            {
                SqlCommand com = null;

                try
                {
                    conn.Open();

                    com = new SqlCommand("SELECT MIN(YEAR) FROM TBLT_PRICE");
                    com.Connection = conn;
                    SqlDataReader cReader = com.ExecuteReader();

                    int year = 0;
                    while (cReader.Read())
                    {
                        if (cReader[0].ToString() != "")
                        {
                            year = int.Parse(cReader[0].ToString());
                        }
                    }
                    cReader.Close();
                    return year;
                }
                catch (Exception ex)
                {
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

        ///////////////////////////////////////////////////////
        // 総額一覧ボタン押下時
        ///////////////////////////////////////////////////////
        private void btnSumShow_Click(object sender, EventArgs e)
        {
            SumPriceListForm form = new SumPriceListForm();
            form.ShowDialog(this);
        }

        private void btnAddressSet_Click(object sender, EventArgs e)
        {
            AddressForm form = new AddressForm();
            form.ShowDialog(this);
        }

        private void btnKindAdd_Click(object sender, EventArgs e)
        {
            KindForm form = new KindForm();
            form.ShowDialog(this);
        }

        private void btnCompanyFormUp_Click(object sender, EventArgs e)
        {
            CompanySearchForm form = new CompanySearchForm();
            form.searchValue = "";
            form.BackColor = groupBox1.BackColor;
            form.ShowDialog(this);
            if (form.selectFlg)
            {
                this.textCode.Text = form.selectCode;
                this.labelName.Text = form.selectName;
            }
        }

        private void btnCodeClear_Click(object sender, EventArgs e)
        {
            textCode.Text = "";
            labelName.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchForm form = new SearchForm();
            form.ShowDialog(this);

        }
    }
}
