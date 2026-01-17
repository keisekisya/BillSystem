using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace BillSystem
{
    class checkString
    {
        static public bool IsDouble(string value)
        {
//            Regex regex = new Regex("^[0-9.]+$");
//            if (!regex.IsMatch(value))
//            {
//                return false;
//            }
            try
            {
                double db = double.Parse(value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }

            return true;
        }

        static public bool IsCode(string value)
        {
            Regex regex = new Regex("^[a-zA-Z0-9]+$");
            if (!regex.IsMatch(value))
            {
                return false;
            }

            return true;
        }

        static public bool IsSyousuTenLen(string value, ref string value2)
        {
            int index = value.IndexOf('.');
            if (index == -1)
            {
                return true;
            }

            string tmp = value.Substring(index + 1);
            if (tmp.Length > 2)
            {
                value2 = value.Substring(0, index + 3);
                return false;
            }
            return true;
        }

        static public bool IsNumber(string value)
        {
            try
            {
                int db = int.Parse(value);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

    }
}
