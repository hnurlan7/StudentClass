using StudentClass.Models;
using System;

namespace StudentClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student( "Nurlan",  "Hamidov",  "Ap103");
            Console.WriteLine(student.GroupNo);
        }
    }
}
