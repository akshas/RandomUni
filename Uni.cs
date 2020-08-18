using System;
using System.Collections.Generic;
using System.Text;

namespace RandomUni
{
    class Uni
    {
        public string Name { get; set; }
        public List<Raum> Zimmer { get; set; }
        public Uni(string name)
        {
            Zimmer = new List<Raum>();
            Name = name; 
        }

        ~Uni()
        {
            Console.WriteLine("Die Uni gibt es nicht mehr");
            Zimmer.Clear();
        }
    }
}
