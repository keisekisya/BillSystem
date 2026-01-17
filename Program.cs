using BillSystem.Const;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BillSystem
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string connect = global::BillSystem.Properties.Settings.Default.DataSource;
            BillFormConst.CONNECT = @"Data Source=" + connect;
            Application.Run(new MainForm());
        }
    }
}
