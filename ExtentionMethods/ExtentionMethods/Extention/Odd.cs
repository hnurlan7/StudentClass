using System;
using System.Collections.Generic;
using System.Text;

namespace ExtentionMethods.Extention
{
    public static class Odd
    {
        public static bool IsOdd(this int num)
        {
            if (num % 2 == 1)
            {
                return true;
            }
            return false;
        }
    }
}
