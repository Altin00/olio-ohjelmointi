using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_10
{
    class Varis : Eläin, ICanFly
    {
        public float WingSize { get; set; }

        public Varis(string _nimi, float _wingSize
        {
            Nimi = _nimi;
            WingSize = _wingSize;
        }

        public void Fly()
        {
            Console.WriteLine("(0) Lentää. Siipien koko on (1)", Nimi, WingSize);
        }

        public override void MakeASound()
        {
            Console.WriteLine("Kakaaw");
        }
    }
}