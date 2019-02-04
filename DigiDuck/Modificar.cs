using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
namespace DigiDuck
{
    public partial class Modificar : Form
    {
       SQLiteConnection con = new SQLiteConnection("Data Source=./Patos.sqlite3;Version=3;New=False;Compress=true;");
        private SQLiteCommand cmd;
        private SQLiteDataAdapter db;
        public Modificar()
        {
            InitializeComponent();
            fillducks();
        }

        private void btnkill_Click(object sender, EventArgs e)
        {
           
            string query = string.Format("delete from Patos where IdDuck = '{0}'",pato.Text);
            con.Open();

          
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            
            con.Close();
        }
        private void setcon()
        {
            con = new SQLiteConnection("Data Source=./Patos.sqlite3;Version=3;New=False;Compress=true;");
        }
        private void fillducks()
        {
            pato.Items.Clear();
            con.Open();

            
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select IdDuck from Patos";
            cmd.ExecuteNonQuery();
         
            DataTable dt = new DataTable();
            SQLiteDataAdapter db = new SQLiteDataAdapter(cmd);
            db.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                pato.Items.Add(dr["IdDuck"]).ToString();
            }
            
            
            con.Close();
            
        }

        private void pato_SelectedIndexChanged(object sender, EventArgs e)
        {
            fill();
        }
        public void fill()
        {
            //     string query = string.Format("select * from Patos where IdDuck = '{0}'",pato.Text);
            //   Sqlite s = new Sqlite();
            //
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Patos where IdDuck = '" + pato.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            //
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(dt);
          
            foreach (DataRow dr in dt.Rows)
            {
                lblnombre.Text = dr["Nombre"].ToString();
                lblfecha.Text = dr["Fecha"].ToString();
                lblquack.Text = dr["Quack"].ToString();
                lblnada.Text = dr["Nada"].ToString();
            }
            con.Close();
        }
    }
}
