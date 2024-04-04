using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<string, Opiskelija> opiskelijat = new Dictionary<string, Opiskelija>();

    static void Main(string[] args)
    {
        while (true)
        {
            NäytäValikko();
            string valinta = Console.ReadLine();

            switch (valinta)
            {
                case "1":
                    LisääOpiskelija();
                   
                  
                   break;
                case "2":
                    PoistaOpiskelija();
                    break;
                case "3":
                    TulostaOpiskelijat();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Virheellinen valinta.");
                    break;
            }
        }
    }

    static void NäytäValikko()
    {
        Console.WriteLine("Valitse toiminto:");
        Console.WriteLine("1. Lisää opiskelija");
        Console.WriteLine("2. Poista opiskelija");
        Console.WriteLine("3. Tulosta kaikki opiskelijat");
        Console.WriteLine("4. Poistu");
    }

    static void LisääOpiskelija()
    {
        
    }

    static void PoistaOpiskelija()
    {
        
    }

    static void TulostaOpiskelijat()
    {
        
    }
}


