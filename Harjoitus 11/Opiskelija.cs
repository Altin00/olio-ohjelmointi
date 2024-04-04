using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_11
{
    internal class Opiskelija
    {
    }
}
class Opiskelija
{
    public string Etunimi { get; set; }
    public string Sukunimi { get; set; }
    public string Ryhmätunnus { get; set; }
    public string OpiskelijaID { get; set; }

    public Opiskelija(string Maija, string Meikälainen, string ABC123, string M8876)  
    {
        Etunimi = Maija;
        Sukunimi = Meikälainen;
        Ryhmätunnus = ABC123;
        OpiskelijaID = M8876;
    }

    public Opiskelija(string Otto, string Kari, string BNT345, string O7780)
    {
        Etunimi = Otto;
        Sukunimi = Kari;
        Ryhmätunnus = BNT345;
        OpiskelijaID = O7780;
    }

}


