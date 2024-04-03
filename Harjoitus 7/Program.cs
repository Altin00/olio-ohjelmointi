class Program
{
    static void Main(string[] args)
    {
        Hissi hissi = new Hissi();

        while (true)
        {
            Console.Write("Anna haluttu kerros (1-6): ");
            if (int.TryParse(Console.ReadLine(), out int haluttuKerros))
            {
                hissi.MeneKerrokseen(haluttuKerros);
            }
            else
            {
                Console.WriteLine("Virheellinen syöte. Anna kokonaisluku väliltä 1-6.");
            }
        }
    }
}



