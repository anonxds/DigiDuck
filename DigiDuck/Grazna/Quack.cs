using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiDuck.Grazna
{
    class Quack : IQuack
    {
        public string TypeQuack()
        {
            InfoDuck d = new InfoDuck();
            d.Grazna = "ahhhhhhhhhhhhhhhhhhhhhhhhhh";
            return d.Grazna;
        }
    }
}
