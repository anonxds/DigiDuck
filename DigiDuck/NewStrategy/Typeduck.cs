using DigiDuck.Nadar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiDuck.NewStrategy
{
    class Mallard2 : ITypeduck
    {
        
        public string infoduck()
        {
            InfoDuck type;
            Ivolar ivolar;
            ivolar = new Flyaway();
          // type.Nombre = "Mallard";
            Swim s = new Swim();
            type.Nada = s.S();

            return type.Nada;

        }
    }
    class Redhead2 : ITypeduck
    {
        public string infoduck()
        {
            throw new NotImplementedException();
        }
    }
    class Rubber2 : ITypeduck
    {
        public string infoduck()
        {
            throw new NotImplementedException();
        }
    }
}
