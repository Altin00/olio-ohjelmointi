using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_9
{
    internal class Kanava_luokka
    {
    }
}
class Kanava
{
    private string nimi;
    private double taajuus;

    public string Nimi
    {
        get { return nimi; }
        set { nimi = value; }
    }

    public double Taajuus
    {
        get { return taajuus; }
        set
        {
            if (value >= 88.0 && value <= 107.9)
            {
                taajuus = value;
            }
            else
            {
                Console.WriteLine("Virhe: Taajuuden tulee olla välillä 88.0-107.9.");
            }
        }
    }

    public Kanava(string nimi, double taajuus)
    {
        Nimi = nimi;
        Taajuus = taajuus;
    }
}