using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_13
{
    internal class Pelaaja
    {
    }
}

class Pelaaja
{
    public string Etunimi { get; set; }
    public string Sukunimi { get; set; }
    public int PelaajaNumero { get; set; }

    public Pelaaja(string etunimi, string sukunimi, int pelaajaNumero)
    {
        Etunimi = etunimi;
        Sukunimi = sukunimi;
        PelaajaNumero = pelaajaNumero;
    }
}

