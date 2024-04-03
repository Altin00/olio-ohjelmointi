using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_9_KT
{
    internal class Radio___luokka
    {
    }
}
class Radio
{
    private bool päällä;
    private int äänenvoimakkuus;
    private double taajuus;

    public bool Päällä
    {
        get { return päällä; }
        set { päällä = value; }
    }

    public int Äänenvoimakkuus
    {
        get { return äänenvoimakkuus; }
        set
        {
            if (value >= 0 && value <= 9)
            {
                äänenvoimakkuus = value;
            }
            else
            {
                Console.WriteLine("Virhe: Äänenvoimakkuuden tulee olla välillä 0-9.");
            }
        }
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

    public Radio()
    {
        Päällä = false;
        Äänenvoimakkuus = 5;
        Taajuus = 88.0;
    }

    public void NäytäTiedot()
    {
        Console.WriteLine($"Radio on {(Päällä ? "päällä" : "pois päältä")}, äänenvoimakkuus: {Äänenvoimakkuus}, taajuus: {Taajuus}");
    }
}


