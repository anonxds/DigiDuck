using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace DigiDuck.Grazna
{
    class Quack : IQuack
    {
        public string TypeQuack()
        {
            InfoDuck d = new InfoDuck();
            d.Grazna = "Quack!";
            return d.Grazna;
        }

        public void Typesound()
        {
            Stream str = Properties.Resources.quack;
            SoundPlayer s = new SoundPlayer(str);
            s.Play();
        }
    }
}
