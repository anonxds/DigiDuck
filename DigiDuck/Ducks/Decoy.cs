using DigiDuck.Grazna;
using DigiDuck.Nadar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DigiDuck.Ducks.fotos;
namespace DigiDuck.Ducks
{
    class Decoy : Iduck
    {
        public void TypeDuck(Label a, Label b, Label c,PictureBox pic)
        {
            IQuack quack;
            Ivolar ivolar;
            quack = new Mute();
            ivolar = new Nofly();
            Swim s = new Swim();
            a.Text = quack.TypeQuack();
            b.Text = ivolar.Comportamiento();
            c.Text = s.S();
            Duckphotos x = new Duckphotos();
            x.decoy(pic);
        }
    }
}
