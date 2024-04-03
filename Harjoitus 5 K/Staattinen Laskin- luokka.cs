using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_5_K
{
    internal class Staattinen_Laskin__luokka
    {
    }
}



class StaattinenLaskin
{
    public static float Summa(float a, float b)
    {
        return a + b;
    }

    public static float Erotus(float a, float b)
    {
        return a - b;
    }

    public static float Kertolasku(float a, float b)
    {
        return a * b;
    }

    public static float Jako(float a, float b)
    {
        if (b != 0)
        {
            return a / b;
        }
        else
        {
            Console.WriteLine("Virhe: Nollalla jakaminen ei ole sallittua.");
            return float.NaN; 
        }
    }
}