using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiDuck.Grazna
{
    class Mute : IQuack
    {
        public string TypeQuack()
        {
            InfoDuck d = new InfoDuck();
            d.Grazna = "..............";
            return d.Grazna;
        }
    }
}
