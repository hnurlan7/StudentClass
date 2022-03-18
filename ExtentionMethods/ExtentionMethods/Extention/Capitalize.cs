using System;
using System.Collections.Generic;
using System.Text;

namespace ExtentionMethods.Extention
{
    public static class Capitalize
    {
        public static string ToCapitalize(this string str)
        {
            return str.Substring(0, 1).ToUpper() + str.Substring(1);
        }
    }
}
