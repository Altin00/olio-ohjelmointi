using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_8
{
    internal class Työntekijä
    {
    }
}
class Työntekijä : Henkilö
{
    public int Viikkotunnit { get; set; }

    public Työntekijä(string nimi, string työpaikka, decimal palkka, int viikkotunnit) : base(nimi, työpaikka, palkka)
    {
        Viikkotunnit = viikkotunnit;
    }

    public override void Esittele()
    {
        Console.WriteLine($"Olen työntekijä {Nimi}, työskentelen {Työpaikka}-yrityksessä ja saan palkkaa {Palkka} kuukaudessa.");
    }
}



