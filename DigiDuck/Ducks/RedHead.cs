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
    class RedHead : Iduck
    {
        public void TypeDuck(Label a, Label b, Label c, PictureBox pic)
        {
            IQuack quack;
            Ivolar ivolar;
            quack = new Quack();
            ivolar = new Flyaway();
            Swim s = new Swim();
            a.Text = quack.TypeQuack();
            b.Text = ivolar.Comportamiento();
            c.Text = s.S();
            quack.Typesound();
            pic.Image = Properties.Resources.redhead;
        }
    }
}
