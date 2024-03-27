using System;


namespace harjoitus1
{




    internal class Program
    {
        private static void Main(string[] arggs)
        {

            Ajoneuvo auto = new Ajoneuvo();
            Ajoneuvo orava = new Ajoneuvo();

            auto.Nimi = "Toyota";
            auto.Nopeus = 200;
            auto.Renkaat = 4;


            orava.Nimi = "BMW";
            orava.Nopeus = 100;
            oeava.Renkaat = 2;

            auto.TulostaData();
            Console.WriteLine();
            orava.TulosData();
            Console.WriteLine();

            string autonTiedot = auto.Tostring();
            Console.WriteLine(autonTiedot);
            
        }   
    }

}

