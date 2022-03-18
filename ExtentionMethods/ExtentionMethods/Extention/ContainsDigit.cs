using System;
using System.Collections.Generic;
using System.Text;

namespace ExtentionMethods.Extention
{
    public static class ContainsDigit
    {
        public static bool IsContainsDigit(this string str)
        {
            foreach (var item in str)
            {
                if (Char.IsDigit(item))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
