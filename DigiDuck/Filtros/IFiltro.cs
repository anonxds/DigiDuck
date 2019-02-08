using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiDuck.Filtros
{
    interface IFiltro
    {
        void Filtrar(DataGridView historial);
    }
}
