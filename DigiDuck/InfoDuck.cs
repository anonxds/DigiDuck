using DigiDuck.Grazna;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiDuck
{
    class InfoDuck
    {
        private string nombre, vuela, nada, grazna, tipo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Vuela { get => vuela; set => vuela = value; }
        public string Nada { get => nada; set => nada = value; }
        public string Grazna { get => grazna; set => grazna = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        public void quack(ComboBox listaquack)
        {
            IQuack quack, mute, squeak;
            quack = new Quack();
            mute = new Mute();
            squeak = new Squeak();
            string[] l = new string[3] { quack.TypeQuack(), mute.TypeQuack(), squeak.TypeQuack() };
            for (int i = 0; i < 3; i++)
            {
                listaquack.Items.Add(l[i]);
            }
        }
    }
}
