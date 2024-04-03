using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_4
{
    internal class Album_luokka
    {
    }
}

class Albumi
{
    public string Nimi { get; set; }
    public string Artisti { get; set; }
    public List<Kappale> Kappaleet { get; } = new List<Kappale>();

    public Albumi(string nimi, string artisti)
    {
        Nimi = nimi;
        Artisti = artisti;
    }

    public void TulostaAlbumi()
    {
        Console.WriteLine($"Albumi: {Nimi}");
        Console.WriteLine($"Artisti: {Artisti}");
        Console.WriteLine("Kappaleet:");
        foreach (var kappale in Kappaleet)
        {
            Console.WriteLine(kappale);
        }
    }
}


