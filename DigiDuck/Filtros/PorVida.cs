using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiDuck.Filtros
{
    class PorVida :  IFiltro
    {
        
        public void Filtrar(DataGridView historial)
        {
            Sqlite s = new Sqlite();
            s.f(historial,"Vive='Si'", "Vive desc");
        }
    }
}
