using System;
using System.Collections.Generic;
using System.Text;

namespace RandomUni
{
    class Dozent : Person
    {
        string DozNum { get; set; }
        public Dozent(string num, string name) : base (name)
        {
            DozNum = num; 
        }
    }
}
