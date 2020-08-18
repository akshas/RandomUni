using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomUni
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            List<Uni> Unis = new List<Uni>();

            foreach(int i  in Enumerable.Range(1, 10))
            {
                Unis.Add(new Uni("Uni" +  i));
            }

            foreach (Uni u in Unis)
            {
                foreach (int i in Enumerable.Range(1, rnd.Next(15, 31)))
                {
                    u.Zimmer.Add(new Raum(i, rnd.Next(20, 30)));
                }
            }


            foreach (Uni u in Unis)
            {
                Console.WriteLine(u.Name + ": " + u.Zimmer.Count() + " Zimmer");
            }
        }
    }
}
