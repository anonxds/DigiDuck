using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiDuck.DB
{
    class Insertar : ADB
    {
        public override void Q(string a,string b,string c,string d, string e, string f)
        {

            Sqlite s = new Sqlite();
            string query = string.Format("insert into Patos values ('{0}','{1}','{2}','{3}','{4}','{5}')",a,b,c,d,e,f);
            s.Exe(query);
        }
    }
}
