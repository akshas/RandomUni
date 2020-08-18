using System;
using System.Collections.Generic;
using System.Text;

namespace RandomUni
{
    class Person
    {
        string Name { get; set; }
        List<Kurs> Kurse;
        public Person(string name)
        {
            Kurse = new List<Kurs>();
            Name = name;
        }
    }
}
