class Program
{
    static void Main(string[] args)
    {
        float luku1 = 10;
        float luku2 = 5;

        Console.WriteLine($"Summa: {luku1} + {luku2} = {StaattinenLaskin.Summa(luku1, luku2)}");
        Console.WriteLine($"Erotus: {luku1} - {luku2} = {StaattinenLaskin.Erotus(luku1, luku2)}");
        Console.WriteLine($"Kertolasku: {luku1} * {luku2} = {StaattinenLaskin.Kertolasku(luku1, luku2)}");
        Console.WriteLine($"Jako: {luku1} / {luku2} = {StaattinenLaskin.Jako(luku1, luku2)}");
    }
}

