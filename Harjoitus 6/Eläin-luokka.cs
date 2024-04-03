using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_6
{
    internal class Eläin_luokka
    {
    }
}
class Eläin
{
    public static int YhteensäLuotu { get; private set; } = 0;

    public string Nimi { get; set; }
    public int Ikä { get; set; }

    public Eläin(string nimi, int ikä)
    {
        Nimi = nimi;
        Ikä = ikä;
        YhteensäLuotu++;
    }

    public virtual void Ääntele()
    {
        Console.WriteLine("Eläin ääntelee...");
    }
}

class Koira : Eläin
{
    public string Rotu { get; set; }

    public Koira(string nimi, int ikä, string rotu) : base(nimi, ikä)
    {
        Rotu = rotu;
    }

    public override void Ääntele()
    {
        Console.WriteLine("Koira haukkuu!");
    }
}

class Kissaeläin : Eläin
{
    public bool OnkoVilli { get; set; }

    public Kissaeläin(string nimi, int ikä, bool onkoVilli) : base(nimi, ikä)
    {
        OnkoVilli = onkoVilli;
    }

    public override void Ääntele()
    {
        Console.WriteLine("Kissaeläin naukuu!");
    }
}


