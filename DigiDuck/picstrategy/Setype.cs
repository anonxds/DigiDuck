using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiDuck.picstrategy
{
    class Setype : showpic
    {
        public override void Send(PictureBox p)
        {
            p.Image = Properties.Resources.mallard;
        }
    }
    class Settrum : showpic
    {
        public override void Send(PictureBox p)
        {
            p.Image = Properties.Resources.Trump;
        }
    }
    class setDecoy : showpic
    {
        public override void Send(PictureBox p)
        {
            p.Image = Properties.Resources.decoy;
        }
    }
    class setRedhead : showpic
    {
        public override void Send(PictureBox pic)
        {
            pic.Image = Properties.Resources.redhead;
        }
    }
    class setRubber : showpic
    {
        public override void Send(PictureBox pic)
        {
            pic.Image = Properties.Resources.rubber;
        }
    }
}
