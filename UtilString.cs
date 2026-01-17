using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillSystem
{
    class UtilString
    {
        static public string changeDelFlg(bool del_flg)
        {
            if (del_flg)
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }

        static public string syousuutennDel(string value)
        {
            int index = value.IndexOf('.');
            if (index == -1)
            {
                return value;
            }

            // 少数点以下の値が無い場合
            string tmp = value.Substring(index + 1);
            if (tmp == "00")
            {
                return value.Substring(0, index);
            }
            // その他は通常通り返す
            return value;
        }

        static public string syousuutennDel(double value)
        {
            string strValue = value.ToString();
            return syousuutennDel(strValue);
        }

        static public string comaDel(string value)
        {
            return value.Replace(",", "");
        }

        static public string syousuutennZeroDel(string value)
        {
            int index = value.IndexOf('.');
            if (index == -1)
            {
                return value;
            }

            // 少数点以下の値が無い場合
            string tmp = value.Substring(index + 1);
            int i;
            bool flag = false;
            for (i = tmp.Length - 1; i >= 0; i--)
            {
                if (tmp[i] != '0')
                {
                    flag = true;
                    break;
                }
            }

            if (flag == true)
            {
                index = index + i + 2;
            }

            string buf = value.Substring(0, index);
            return value.Substring(0, index);
        }

        ///////////////////////////
        /// 小数点以下の値があるかチェックする
        ///////////////////////////
        static public bool IsSyousuutennData(string value)
        {
            int index = value.IndexOf('.');
            if (index == -1)
            {
                return false;
            }

            string tmp = value.Substring(index + 1);
            for (int i = tmp.Length - 1; i >= 0; i--)
            {
                // 少数点以下の値がある場合
                if (tmp[i] != '0')
                {
                    return true;
                }
            }
            return false;
        }

        static public string getLastDay(string year, string month)
        {
            string[] day = { "31", "28", "31", "30", "31", "30", "31", "31", "30", "31", "30", "31" };
            string[] uday = { "31", "29", "31", "30", "31", "30", "31", "31", "30", "31", "30", "31" };

            int iyear = int.Parse(year);
            int imonth = int.Parse(month);

            //うるう年の算出

            if((iyear % 4 == 0 && iyear % 100 != 0) || (iyear % 400 == 0))
            {
                return uday[imonth - 1];
            } else{
                return day[imonth - 1];
            }
        }
    }
}
