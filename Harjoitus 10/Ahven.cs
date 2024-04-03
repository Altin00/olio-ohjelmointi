using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_10
{
    class Ahven : Eläin, ICanSwim
    {
        public int SwimSpeed { get; set; }
        public string Sound { get; set; }

        public Kala(string _nimi, int _speed, string _sound)
        {
            Ními = _nimi;
            SWimSpeed = _speed;
            Sound = _sound;
        }

        public override void MakeASound()
        {
            Console.WriteLine("Blurp");
        }

        public void Swim()
        {
            Console.WriteLine("Kala (0) ui nopeudella (1)", Nimi SwimSpeed);
        }
    }
}
