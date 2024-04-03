class Program
{
    static void Main(string[] args)
    {
        Radio radio = new Radio();

        while (true)
        {
            Console.WriteLine("Valitse toiminto:");
            Console.WriteLine("1. Päälle / Pois");
            Console.WriteLine("2. Äänenvoimakkuus");
            Console.WriteLine("3. Taajuus");
            Console.WriteLine("4. Näytä tiedot");
            Console.WriteLine("0. Lopeta");

            int valinta;
            if (int.TryParse(Console.ReadLine(), out valinta))
            {
                switch (valinta)
                {
                    case 1:
                        radio.Päällä = !radio.Päällä;
                        Console.WriteLine($"Radio on nyt {(radio.Päällä ? "päällä" : "pois päältä")}");
                        break;
                    case 2:
                        Console.Write("Anna äänenvoimakkuus (0-9): ");
                        int äänenvoimakkuus;
                        if (int.TryParse(Console.ReadLine(), out äänenvoimakkuus))
                        {
                            radio.Äänenvoimakkuus = äänenvoimakkuus;
                        }
                        break;
                    case 3:
                        Console.Write("Anna taajuus (88.0-107.9): ");
                        double taajuus;
                        if (double.TryParse(Console.ReadLine(), out taajuus))
                        {
                            radio.Taajuus = taajuus;
                        }
                        break;
                    case 4:
                        radio.NäytäTiedot();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Virheellinen valinta.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Virheellinen syöte. Anna kokonaisluku.");
            }
        }
    }
}