using DigiDuck.Ducks.fotos;
using DigiDuck.Grazna;
using DigiDuck.Nadar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiDuck.Ducks
{
    class Rubber : Iduck
    {
        public void TypeDuck(Label a, Label b, Label c, PictureBox pic)
        {
            IQuack quack;
            Ivolar ivolar;
            quack = new Squeak();
            ivolar = new Nofly();
            Swim s = new Swim();
            a.Text = quack.TypeQuack();
            b.Text = ivolar.Comportamiento();
            c.Text = s.S();
            quack.Typesound();
            Duckphotos x = new Duckphotos();
            x.rubber(pic);
        }
    }
}
