
{
    static void Main(string[] args)
    {
        Albumi albumi1 = new Albumi("Dark Side of the Moon", "Pink Floyd")
        {
            Kappaleet =
            {
                new Kappale("Speak to Me", "Pink Floyd", 1.07),
                new Kappale("Breathe", "Pink Floyd", 2.43),
                new Kappale("Money", "Pink Floyd", 6.22),
                new Kappale("Us and Them", "Pink Floyd", 7.51)
            }
        };

        Albumi albumi2 = new Albumi("Thriller", "Michael Jackson")
        {
            Kappaleet =
            {
                new Kappale("Wanna Be Startin' Somethin'", "Michael Jackson", 6.03),
                new Kappale("Billie Jean", "Michael Jackson", 4.54),
                new Kappale("Beat It", "Michael Jackson", 4.18),
                new Kappale("Thriller", "Michael Jackson", 5.57)
            }
        };

        Albumi albumi3 = new Albumi("Back in Black", "AC/DC")
        {
            Kappaleet =
            {
                new Kappale("Hells Bells", "AC/DC", 5.12),
                new Kappale("Shoot to Thrill", "AC/DC", 5.17),
                new Kappale("Back in Black", "AC/DC", 4.15),
                new Kappale("You Shook Me All Night Long", "AC/DC", 3.30)
            }
        };

        albumi1.TulostaAlbumi();
        albumi2.TulostaAlbumi();
        albumi3.TulostaAlbumi();
    }
}

