using System;
using System.Collections.Generic;
using System.Text;

namespace RandomUni
{
    class Kurs
    {
        string KursName { get; set; }
        public List<Student> Studente;
        public Kurs(string kname)
        {
            Studente = new List<Student>();
            KursName = kname;
        }

    }
}
