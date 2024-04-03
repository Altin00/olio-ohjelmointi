using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_8
{
    internal class Pomo
    {
    }
}
class Pomo : Henkilö
{
    public decimal Boonus { get; set; }
    public string Auto { get; set; }
    private static bool pomoLuotu = false;

    public Pomo(string nimi, string työpaikka, decimal palkka, decimal boonus, string auto) : base(nimi, työpaikka, palkka)
    {
        if (pomoLuotu)
        {
            throw new InvalidOperationException("Vain yksi pomo voi olla olemassa.");
        }
        else
        {
            Boonus = boonus;
            Auto = auto;
            pomoLuotu = true;
        }
    }

    public override void Esittele()
    {
        Console.WriteLine($"Olen pomo {Nimi}, työskentelen {Työpaikka}-yrityksessä ja saan palkkaa {Palkka} kuukaudessa. Lisäksi saan bonusta {Boonus} ja ajan autolla {Auto}.");
    }
}
