using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiDuck.Grazna
{
    class Squeak : IQuack
    {
        public string TypeQuack()
        {
            InfoDuck d = new InfoDuck();
            d.Grazna = "Squeakkkkkkkkkkkkkkkk";
            return d.Grazna;
        }
    }
}
