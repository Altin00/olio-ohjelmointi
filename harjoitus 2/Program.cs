using Harjoitus_2;
using System;

namespace Harjoitus_2
{

    class Program
    {
        static void Main(string[] args)
        {

            Opiskelija opiskelija1 = new Opiskelija("Matti", "TVT1234", 0);

            opiskelija1.TulostaData();
            opiskelija1.MuokkaOpintopisteitä(5);
            opiskelija1.TulostaData();
        }


    }

}
