using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiDuck.Filtros
{
    class Squeaks : IFiltro
    {
        public void Filtrar(DataGridView historial)
        {
            Sqlite s = new Sqlite();
            s.f(historial, "Quack='Squeak'", "Quack desc");
        }
    }
}
