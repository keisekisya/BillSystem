using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using BillSystem.Const;

namespace BillSystem
{
    class DbAccessFunc
    {
        static public bool getAddressInfo(ref AddressInfo info)
        {
            // DBよりデータを取得
            using (SqlConnection conn = new SqlConnection(BillFormConst.CONNECT))
            {
                SqlCommand com = null;

                try
                {
                    conn.Open();

                    com = conn.CreateCommand();
                    com.CommandText = "SELECT TO_NAME,FROM_NAME,FROM_ADDRESS_1,FROM_ADDRESS_2,FROM_TEL,FROM_INVOICE_NO FROM TBLM_ADDRESS WHERE UPKEY='1'";
                    com.Connection = conn;

                    SqlDataReader cReader = com.ExecuteReader();

                    bool retFlg = false;
                    if (cReader.Read())
                    {
                        info.to_name = cReader["TO_NAME"].ToString();
                        info.from_name = cReader["FROM_NAME"].ToString();
                        info.from_address1 = cReader["FROM_ADDRESS_1"].ToString();
                        info.from_address2 = cReader["FROM_ADDRESS_2"].ToString();
                        info.from_tel = cReader["FROM_TEL"].ToString();
                        info.from_invoice_no = cReader["FROM_INVOICE_NO"].ToString();

                        retFlg = true;
                    }
                    cReader.Close();
                    return retFlg;
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

        static public List<BillCompanyInfo> getCompanyGroupData(string year, string month, ref long sumprice)
        {
            // DBよりデータを取得
            using (SqlConnection conn = new SqlConnection(BillFormConst.CONNECT))
            {
                SqlCommand com = null;

                try
                {
                    long tmpSumPrice = 0;
                    List<BillCompanyInfo> data = new List<BillCompanyInfo>();
                    conn.Open();

                    com = conn.CreateCommand();
                    com.Connection = conn;

                    // スリッター、トムソン
                    StringBuilder sqlbufKind1 = new StringBuilder();
                    sqlbufKind1.Append("SELECT B.NAME,B.CODE, SUM(A.PRICE) AS PRICE FROM TBLT_PRICE A, TBLM_KIND B ");
                    sqlbufKind1.Append("WHERE A.KIND_CODE = B.CODE AND A.YEAR = @year AND A.MONTH = @month AND KEY_COMPANY_CODE = '' AND (KIND_CODE = 'SLT' OR KIND_CODE = 'TOM') ");
                    sqlbufKind1.Append("GROUP BY B.NAME,B.CODE ORDER BY B.CODE");
                    com.CommandText = sqlbufKind1.ToString();
                    com.Parameters.AddWithValue("@year", year);
                    com.Parameters.AddWithValue("@month", month);

                    SqlDataReader cReader = com.ExecuteReader();

                    long tomPrice = 0;
                    StringBuilder tomStr = new StringBuilder();
                    while (cReader.Read())
                    {
                        if (tomStr.Length != 0)
                        {
                            tomStr.Append("、");
                        }
                        tomStr.Append(cReader["NAME"].ToString());
                        tomPrice = tomPrice + long.Parse(cReader["PRICE"].ToString());
                    }
                    cReader.Close();
                    if (tomStr.Length != 0)
                    {
                        BillCompanyInfo info = new BillCompanyInfo();
                        tomStr.Append(" 代");
                        info.name = tomStr.ToString();
                        info.price = tomPrice;
                        tmpSumPrice = tmpSumPrice + tomPrice;
                        data.Add(info);
                    }

                    // スリッター、トムソン以外の種類
                    StringBuilder sqlbufKind2 = new StringBuilder();
                    sqlbufKind2.Append("SELECT B.NAME,B.CODE, SUM(A.PRICE) AS PRICE FROM TBLT_PRICE A, TBLM_KIND B ");
                    sqlbufKind2.Append("WHERE A.KIND_CODE = B.CODE AND A.YEAR = @year AND A.MONTH = @month AND KEY_COMPANY_CODE = '' AND KIND_CODE <> 'SLT' AND KIND_CODE <> 'TOM' ");
                    sqlbufKind2.Append("GROUP BY B.NAME,B.CODE ORDER BY B.CODE");
                    com.CommandText = sqlbufKind2.ToString();

                    cReader = com.ExecuteReader();

                    long otherKindPrice = 0;
                    StringBuilder otherKindStr = new StringBuilder();
                    while (cReader.Read())
                    {
                        if (otherKindStr.Length != 0)
                        {
                            otherKindStr.Append("、");
                        }
                        otherKindStr.Append(cReader["NAME"].ToString());
                        otherKindPrice = otherKindPrice + long.Parse(cReader["PRICE"].ToString());
                    }
                    cReader.Close();
                    if (otherKindStr.Length != 0)
                    {
                        BillCompanyInfo info = new BillCompanyInfo();
                        otherKindStr.Append(" 代");
                        info.name = otherKindStr.ToString();
                        info.price = otherKindPrice;
                        tmpSumPrice = tmpSumPrice + otherKindPrice;
                        data.Add(info);
                    }

                    StringBuilder sqlbuf = new StringBuilder();
                    sqlbuf.Append("SELECT B.NAME,A.KEY_COMPANY_CODE, SUM(A.PRICE) AS PRICE FROM TBLT_PRICE A, TBLM_COMPANY B ");
                    sqlbuf.Append("WHERE A.KEY_COMPANY_CODE = B.CODE AND A.YEAR = @year AND A.MONTH = @month AND KEY_COMPANY_CODE <> '' ");
                    sqlbuf.Append("GROUP BY B.NAME,A.KEY_COMPANY_CODE");

                    com.CommandText = sqlbuf.ToString();

                    cReader = com.ExecuteReader();
                    while (cReader.Read())
                    {
                        BillCompanyInfo info = new BillCompanyInfo();
                        info.name = cReader["NAME"].ToString();
                        info.price = long.Parse(cReader["PRICE"].ToString());
                        tmpSumPrice = tmpSumPrice + info.price;
                        data.Add(info);
                    }
                    cReader.Close();

                    // 例外
                    StringBuilder sqlbufExp = new StringBuilder();
                    sqlbufExp.Append("SELECT REMARKS,PRICE ");
                    sqlbufExp.Append("FROM TBLT_EXCEPTION_PRICE ");
                    sqlbufExp.Append("WHERE YEAR = @year AND MONTH = @month ");
                    sqlbufExp.Append("ORDER BY LINE ");

                    com.CommandText = sqlbufExp.ToString();

                    cReader = com.ExecuteReader();
                    while (cReader.Read())
                    {
                        BillCompanyInfo info = new BillCompanyInfo();
                        info.name = cReader["REMARKS"].ToString();
                        info.price = long.Parse(cReader["PRICE"].ToString());
                        tmpSumPrice = tmpSumPrice + info.price;
                        data.Add(info);
                    }
                    cReader.Close();

                    // 消費税の算出
                    BillCompanyInfo infoTax = new BillCompanyInfo();
                    double tax = global::BillSystem.Properties.Settings.Default.Tax;
                    infoTax.name = "消 費 税 (税率：" + tax + "%)";
                    infoTax.price = (long)(tmpSumPrice * (tax / 100));
                    data.Add(infoTax);

                    // 総合計
                    sumprice = tmpSumPrice + infoTax.price;
                    

                    return data;
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
