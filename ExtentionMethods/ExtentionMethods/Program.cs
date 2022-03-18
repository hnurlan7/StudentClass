using System;
using ExtentionMethods.Extention;

namespace ExtentionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = 2;
            //Console.WriteLine(num.IsOdd());

            //int num = 9;
            //Console.WriteLine(num.IsEven());

            //string str = "hnurlan7_";
            //Console.WriteLine(str.IsContainsDigit());

            string str = "nurlan";
            Console.WriteLine(str.ToCapitalize());
        }
    }
}
