using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> kortit = LuoKorttipakka();
        TulostaKortit("Alkuperäinen korttipakka:", kortit);

        SekoitaKortit(kortit);
        TulostaKortit("Sekoitetut kortit:", kortit);
    }

    static List<string> LuoKorttipakka()
    {
        List<string> kortit = new List<string>();

        string[] maat = { "Hertta", "Ruutu", "Risti", "Pata" };
        string[] numerot = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jätkä", "Rouva", "Kuningas" };

        int kortinNumero = 1;
        foreach (string maa in maat)
        {
            foreach (string numero in numerot)
            {
                kortit.Add($"{kortinNumero}. Kortti on {maa} - {numero}");
                kortinNumero++;
            }
        }

        return kortit;
    }

    static void SekoitaKortit(List<string> kortit)
    {
        Random rng = new Random();
        int n = kortit.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            string arvo = kortit[k];
            kortit[k] = kortit[n];
            kortit[n] = arvo;
        }
    }

    static void TulostaKortit(string otsikko, List<string> kortit)
    {
        Console.WriteLine(otsikko);
        foreach (string kortti in kortit)
        {
            Console.WriteLine(kortti);
        }
        Console.WriteLine();
    }
}
