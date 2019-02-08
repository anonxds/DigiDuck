using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiDuck.Filtros
{
    class PorMallard: IFiltro
    {
      

        public void Filtrar(DataGridView historial)
        {
            Sqlite s = new Sqlite();
            s.f(historial, "Tipo='Mallard'", "Vive desc");
        }
    }
}
