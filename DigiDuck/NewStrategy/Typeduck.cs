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
           string Nombre = "Mallard";
            Swim s = new Swim();
            string Nada = s.S();

            return  Nombre;
           

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
