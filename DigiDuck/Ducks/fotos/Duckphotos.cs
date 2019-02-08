using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiDuck.Ducks.fotos
{
    class Duckphotos
    {
        public void toy(PictureBox pic)
        {
            pic.Image = Properties.Resources.Trump;
        }
        public void redhead(PictureBox pic)
        {
            pic.Image = Properties.Resources.redhead;

        }
        public void rubber(PictureBox pic)
        {
            pic.Image = Properties.Resources.rubber;

        }
        public void decoy(PictureBox pic)
        {
            pic.Image = Properties.Resources.decoy;

        }
    }
}
