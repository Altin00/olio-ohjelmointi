using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_10
{
    class Program
    {

        static void Main(string[] args)
        {
            Varis varis = new Varis("Varis", 90);

            varis.MakeASound();
            varis.Fly();

            Kala ahven = new Kala("Ahven", 50, "Blurps");

            ahven.MakeASound();
            ahven.SWim();

            Sorsa sorsa = new Soesa("Soesa", 90, 10);

            sorsa.MakeASound();
            sorsa.Fly();
            sorsa.MakeASound();
            sorsa.Swim();
        }
    }
}

