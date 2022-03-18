using System;
using System.Collections.Generic;
using System.Text;

namespace ExtentionMethods.Extention
{
    public static class Even
    {
        public static bool IsEven(this int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
