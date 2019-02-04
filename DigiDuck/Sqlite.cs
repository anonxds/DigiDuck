using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
namespace DigiDuck
{
    class Sqlite
    {
        private SQLiteConnection con;
        private SQLiteCommand cmd;
        private SQLiteDataAdapter db;
        private void setcon()
        {
            con = new SQLiteConnection("Data Source=./Patos.sqlite3;Version=3;New=False;Compress=true;");
        }
        public void Exe(string query)
        {
            setcon();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}
