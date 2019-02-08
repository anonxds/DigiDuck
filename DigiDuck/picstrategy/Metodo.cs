using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiDuck.picstrategy
{
    class Metodo
    {
        private PictureBox P; 
        private showpic _showpic;
        public void Setpic(showpic Showpic)
        {
            this._showpic = Showpic;

        }
        public void spic(PictureBox p)
        {
            P = p;
        }
        public void show()
        {
            _showpic.Send(P);
        }

    }
}
