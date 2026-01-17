using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BillSystem
{
    public partial class printForm : Form
    {
        public bool okFlag  { get; set; }
        public string day  { get; set; }

        public printForm()
        {
            InitializeComponent();
        }

        /////////////////////////////////////////////
        // 画面表示時
        /////////////////////////////////////////////
        private void printForm_Load(object sender, EventArgs e)
        {
            // 日付のコンボボックスに設定
            for (int i = 1; i <= 31; i++)
            {
                boxDay.Items.Add(String.Format("{0:D2}", i));
            }
            boxDay.Text = day;
        }

        /////////////////////////////////////////////
        // 印刷ボタン押下時
        /////////////////////////////////////////////
        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.day = boxDay.Text;
            okFlag = true;
            this.Close();
        }
    }
}
