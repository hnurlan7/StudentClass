using System;
using System.Collections.Generic;
using System.Text;

namespace StudentClass.Models
{
    public class Student
    {
        private string _groupNo;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string GroupNo
        {
            get { return _groupNo; }
            set
            {
                
                for (int i = 0; i < value.Length; i++)
                {
                    if (value.Length == 5 && Char.IsUpper(value[0]) && Char.IsUpper(value[1]) && Char.IsDigit(value[2]) && Char.IsDigit(value[3]) && Char.IsDigit(value[4]))
                    {
                        _groupNo = value;
                        return;
                    }
                    
                }
                Console.WriteLine("Exam: AP103");
            }
        }




        public Student(string name, string surname, string groupNo)
        {
            Name = name;
            Surname = surname;
            GroupNo = groupNo;
        }


    }
}
