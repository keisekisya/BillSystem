using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using BillSystem.Const;

namespace BillSystem
{
    class yearUtil
    {
        static public string getGenGou(string paramYear, string paramMonth)
        {
            // DBよりデータを取得
            using (SqlConnection conn = new SqlConnection(BillFormConst.CONNECT))
            {
                SqlCommand com = null;

                try
                {
                    conn.Open();

                    com = new SqlCommand("select TOP 1 YEARMONTH, GENGOU FROM TBLM_GENGOU WHERE YEARMONTH <= @year ORDER BY YEARMONTH DESC");
                    com.Connection = conn;
                    com.Parameters.AddWithValue("@year", paramYear + paramMonth);

                    SqlDataReader cReader = com.ExecuteReader();

                    StringBuilder rtnStr = new StringBuilder();
                    while (cReader.Read())
                    {
                        string year = cReader[0].ToString();
                        int gYear = int.Parse(paramYear) - int.Parse(year.Substring(0, 4)) + 1;
                        rtnStr.Append(cReader[1].ToString());
                        rtnStr.Append(" ");
                        rtnStr.Append(gYear);
                    }
                    cReader.Close();
                    return rtnStr.ToString();
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
    }
}
