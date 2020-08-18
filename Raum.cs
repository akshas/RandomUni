using System;
using System.Collections.Generic;
using System.Text;

namespace RandomUni
{
    class Raum
    {
        public int Num { get; set; }
        public int AnzSitze { get; set; }
        public Raum(int num, int anz)
        {
            Num = num;
            AnzSitze = anz;
        }
    }
}
