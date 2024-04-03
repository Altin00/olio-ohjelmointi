using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_8
{
    internal class Henkilö
    {
    }
}


 abstract class Henkilö
{
    public string Nimi { get; set; }
    public string Työpaikka { get; set; }
    public decimal Palkka { get; set; }

    protected Henkilö(string Otto, string Myyjä, decimal 1500)
    {
        Nimi = Otto;
        Työpaikka = Myyjä;
        Palkka = 1500;
    }

    public abstract void Esittele();
}