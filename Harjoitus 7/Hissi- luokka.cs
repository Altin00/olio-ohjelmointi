using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_7
{
    internal class Hissi__luokka
    {
    }
}



class Hissi
{
    private int kerros;

    public int Kerros
    {
        get { return kerros; }
        private set { kerros = value; }
    }

    public Hissi()
    {
        Kerros = 1; 
    }

    public void MeneKerrokseen(int haluttuKerros)
    {
        if (haluttuKerros < 1 || haluttuKerros > 6)
        {
            Console.WriteLine("Virhe: Kerroksen on oltava välillä 1-6.");
        }
        else
        {
            Kerros = haluttuKerros;
            Console.WriteLine("Hissi saavutti kerroksen {Kerros}.");
        }
    }
}

