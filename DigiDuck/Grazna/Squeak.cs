using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace DigiDuck.Grazna
{
    class Squeak : IQuack
    {
        public string TypeQuack()
        {
            InfoDuck d = new InfoDuck();
            d.Grazna = "Squeak";
            return d.Grazna;
        }

        public void Typesound()
        {
            Stream stream = Properties.Resources.clown;
            SoundPlayer s = new SoundPlayer(stream);
            s.Play();
        }
    }
}
