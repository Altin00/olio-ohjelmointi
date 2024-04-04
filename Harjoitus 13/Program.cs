class Program
{
    static void Main()
    {
        Joukkue joukkue = new Joukkue("Esimerkkijoukkue", "Esimerkkikaupunki");

        Pelaaja pelaaja1 = new Pelaaja("Matti", "Meikäläinen", 10);
        Pelaaja pelaaja2 = new Pelaaja("Teppo", "Testaaja", 20);

        joukkue.LisääPelaaja(pelaaja1);
        joukkue.LisääPelaaja(pelaaja2);

        Console.WriteLine("Joukkueen pelaajat:");
        List<Pelaaja> pelaajat = joukkue.HaePelaajat();
        foreach (var pelaaja in pelaajat)
        {
            Console.WriteLine("Pelaaja: {pelaaja.Etunimi} {pelaaja.Sukunimi}, Numero: {pelaaja.PelaajaNumero}");
        }

        Console.WriteLine("Poistetaan pelaaja numero 10...");
        joukkue.PoistaPelaaja(10);

        Console.WriteLine("Joukkueen pelaajat:");
        pelaajat = joukkue.HaePelaajat();
        foreach (var pelaaja in pelaajat)
        {
            Console.WriteLine("Pelaaja: {pelaaja.Matti} {pelaaja.Sukunimi}, Numero: {pelaaja.PelaajaNumero}"); 
        }
    }
}
