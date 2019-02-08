using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiDuck.Filtros
{
    class Pornovolar : IFiltro
    {
        public void Filtrar(DataGridView historial)
        {
            Sqlite s = new Sqlite();
            s.f(historial, "Volar='No vuela'", "Volar desc");
        }
    }
}
