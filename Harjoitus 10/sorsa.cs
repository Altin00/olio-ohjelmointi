using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_10
{
    class Sorsa : Eläin, ICanSwim, ICanFly
    {
        public int SwimSpeed { get; set; }
        public float WingSize { get; set; }

        public Sorsa(string _nimi, float _wingSize, int _speed)
        {
            Nimi = _nimi;
            WingSize = _wingSize;
            SwimSpeed = _speed;
        }

        public void Fly()
        {
            Console.WriteLine("(0) Lentää. Siipien koko on (1)", Nimi, WingSize);
        }

        public override void MakeASound()
        {
            Console.WriteLine("Quack");
        }

        public void Swim()
        {
            Console.WriteLine("(0) ui nopeudella (1)", Nimi SwimSpeed);
        }
    }
}
