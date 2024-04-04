using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_13
{
    internal class Joukkue
    {
    }
}

class Joukkue
{
    public string Nimi { get; set; }
    public string Kotikaupunki { get; set; }
    private Dictionary<int, Pelaaja> Pelaajat { get; set; }

    public Joukkue(string nimi, string kotikaupunki)
    {
        Nimi = nimi;
        Kotikaupunki = kotikaupunki;
        Pelaajat = new Dictionary<int, Pelaaja>();
    }

    public Pelaaja HaePelaaja(int pelaajaNumero)
    {
        try
        {
            return Pelaajat[pelaajaNumero];
        }
        catch (KeyNotFoundException)
        {
            Console.WriteLine("Pelaajaa numerolla {pelaajaNumero} ei löydy.");
            return null;
        }
    }

    public void LisääPelaaja(Pelaaja pelaaja)
    {
        try
        {
            Pelaajat.Add(pelaaja.PelaajaNumero, pelaaja);
            Console.WriteLine("Pelaaja {pelaaja.Etunimi} {pelaaja.Sukunimi} lisätty joukkueeseen.");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Pelaaja numerolla {pelaaja.PelaajaNumero} on jo joukkueessa.");
        }
    }

    public void PoistaPelaaja(int pelaajaNumero)
    {
        if (Pelaajat.Remove(pelaajaNumero))
        {
            Console.WriteLine("Pelaaja numerolla {pelaajaNumero} poistettu joukkueesta.");
        }
        else
        {
            Console.WriteLine("Pelaajaa numerolla {pelaajaNumero} ei löydy joukkueesta.");
        }
    }

    public List<Pelaaja> HaePelaajat()
    {
        return new List<Pelaaja>(Pelaajat.Values);
    }
}
