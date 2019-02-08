using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiDuck.Filtros
{
    class PorQuack : IFiltro
    {
        public void Filtrar(DataGridView historial)
        {
            Sqlite s = new Sqlite();
            s.f(historial, "Quack='Quack!'", "Tipo desc");
        }
    }
    class Pormute : IFiltro
    {
        public void Filtrar(DataGridView historial)
        {
            Sqlite s = new Sqlite();
            s.f(historial, "Quack='..............'", "Tipo desc");
        }
    }
}
