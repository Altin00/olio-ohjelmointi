
class Program
{
    static void Main()
    {
        string tiedostoPolku = "muistiinpanot.txt";
        List<string> muistiinpanot = new List<string>();

        Console.WriteLine("Tervetuloa muistiinpano-ohjelmaan!");

        while (true)
        {
            Console.WriteLine("Käytettävissä olevat komennot:");
            Console.WriteLine("1. Uusi muistiinpano");
            Console.WriteLine("2. Tulosta muistiinpanot");
            Console.WriteLine("3. Lopeta");
            Console.Write("Valitse komento (1-3): ");
            string valinta = Console.ReadLine();

            switch (valinta)
            {
                case "1":
                    Console.Write("Syötä uusi muistiinpano: ");
                    string uusiMuistiinpano = Console.ReadLine();
                    muistiinpanot.Add(uusiMuistiinpano);
                    TallennaMuistiinpanotTiedostoon(muistiinpanot, tiedostoPolku);
                    Console.WriteLine("Muistiinpano tallennettu!");
                    break;

                case "2":
                    TulostaMuistiinpanotTiedostosta(tiedostoPolku);
                    break;

                case "3":
                    Console.WriteLine("Ohjelma suljetaan.");
                    return;

                default:
                    Console.WriteLine("Virheellinen valinta. Valitse 1-3.");
                    break;
            }
        }
    }

    private static void TulostaMuistiinpanotTiedostosta(string tiedostoPolku)
    {
        
    }

    private static void TallennaMuistiinpanotTiedostoon(List<string> muistiinpanot, string tiedostoPolku)
    {
       
    }
}









