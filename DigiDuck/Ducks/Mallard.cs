using DigiDuck.Grazna;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiDuck.Nadar;
using System.Windows.Forms;
using DigiDuck.Ducks.fotos;
namespace DigiDuck.Ducks
{
    class Mallard : Iduck
    {
        public void TypeDuck(Label a, Label b,Label c, PictureBox pic)
        {
            Ivolar ivolar;
            IQuack quack;
            Swim s = new Swim();
            ivolar = new Flyaway();
            quack = new Quack();
            a.Text = ivolar.Comportamiento();
            b.Text = quack.TypeQuack();
            c.Text = s.S();
            quack.Typesound();
            PMallard d = new PMallard();
            d.p(pic);

        }
    }
}
