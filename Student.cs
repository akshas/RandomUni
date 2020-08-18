using System;
using System.Collections.Generic;
using System.Text;

namespace RandomUni
{
    class Student : Person
    {
        string StNum { get; set; }
        public Student(string num, string name) : base (name)
        {
            StNum = num; 
        }
    }
}
