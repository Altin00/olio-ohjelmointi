using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus_2
{
    internal class opiskelija
    {
        private string Nimi { get; set; }

        private string OpiskelijaID { get; set; }

        private int Opintopisteet { get; set; }






        public opiskelija(string _nimi, string _id, int _op)
        {
            Nimi = _nimi;
            OpiskelijaID = _id;
            Opintopisteet = _op;
        }

        public void TulostaData()
        {
            Console.WriteLine("");
            Console.WriteLine("Opiskelija: ");
            Console.WriteLine("--Nimi: " + Nimi);
            Console.WriteLine("--Opiskelijan ID: " + OpiskelijaID);
            Console.WriteLine("-- Opintopisteet: " + Opintopisteet);
            Console.WriteLine("");
        }

        public void MuokkaOpintopisteitä(int i)
        {
            Opintopisteet += i;

            if (Opintopisteet < 0)
            {
                Opintopisteet = 0;
            }

        }
    }
}
