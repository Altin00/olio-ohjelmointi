




{
    static void Main(string[] args)
    {
        Kiuas kiuas = new Kiuas(); 

        kiuas.Päällä = true;
        kiuas.Lämpötila = 70;
        kiuas.Kosteus = 50;
        kiuas.Päällä = false;

        Console.WriteLine("Kiuas on nyt " + (kiuas.Päällä ? "päällä" : "pois päältä"));
        Console.WriteLine("Kiuaksen lämpötila on nyt: " + kiuas.Lämpötila + " astetta");
        Console.WriteLine("Kiuaksen kosteus on nyt: " + kiuas.Kosteus + "%");
    }
}



