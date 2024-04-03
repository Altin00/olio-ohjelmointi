class Program
{
    static void Main(string[] args)
    {
        Koira koira = new Koira("Musti", 5, "Mäyräkoira");
        Kissaeläin kissa = new Kissaeläin("Kissa", 3, false);
        Koira toinenKoira = new Koira("Rex", 2, "Labradorinnoutaja");

        // Tulostetaan eläinten ääntelyt
        koira.Ääntele();
        kissa.Ääntele();
        toinenKoira.Ääntele();

        // Tulostetaan yhteensä luotujen eläinten määrä
        Console.WriteLine($"Yhteensä luotu eläimiä: {Eläin.YhteensäLuotu}");
    }
}
