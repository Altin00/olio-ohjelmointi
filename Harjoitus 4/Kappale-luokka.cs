using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_4
{
    internal class Kappale_luokka
    {
    }
}
class Kappale
{
    public string Nimi { get; set; }
    public string Artisti { get; set; }
    public double Kesto { get; set; }

    public Kappale(string nimi, string artisti, double kesto)
    {
        Nimi = nimi;
        Artisti = artisti;
        Kesto = kesto;
    }

    public override string ToString() => $"{Nimi} - {Artisti} ({Kesto} min)";
}


