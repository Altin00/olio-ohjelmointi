

class Program
{
    static void Main(string[] args)
    {
        // Luodaan työntekijä
        Työntekijä työntekijä = new Työntekijä("Matti Meikäläinen", "Esimerkkifirma Oy", 3000, 40);
        työntekijä.Esittele();

        // Luodaan pomo (huomaa, että vain yksi pomo voi olla olemassa)
        Pomo pomo = new Pomo("Eeva Esimies", "Esimerkkifirma Oy", 5000, 1000, "Audi");
        pomo.Esittele();
    }
}