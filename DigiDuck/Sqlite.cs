using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;

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
        public void f(DataGridView historial,string x, string y)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=./Patos.sqlite3;Version=3;New=False;Compress=true;");
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            con.Open();
            cmd = con.CreateCommand();
            string cmdt = "select * from historial";
            db = new SQLiteDataAdapter(cmdt, con);
            ds.Reset();
            db.Fill(ds);
            dt = ds.Tables[0];
            historial.DataSource = dt;
            con.Close();
            DataView da = new DataView(dt, x, y, DataViewRowState.CurrentRows);
            historial.DataSource = da;
        }
        public void _volar(ComboBox listavolar)
        {
            Ivolar ivolar, novolar, rocket;
            ivolar = new Flyaway();
            novolar = new Nofly();
            rocket = new Rocketpower();
            listavolar.Items.Add(ivolar.Comportamiento());
            listavolar.Items.Add(novolar.Comportamiento());
            listavolar.Items.Add(rocket.Comportamiento());

        }
    }
}
