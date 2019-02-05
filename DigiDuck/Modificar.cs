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
using DigiDuck.Grazna;

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
            volar();
            quack();
            tableHis();
        }

        private void btnkill_Click(object sender, EventArgs e)
        {
            InfoDuck d = new InfoDuck();
            Sqlite s = new Sqlite();
            string matar = string.Format("insert into historial values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", DateTime.Now.ToString("yyyy-MM-dd HH:mm"), txtnombre.Text, listaquack.Text, d.Nada, listavolar.Text, "No", pato.Text);
            s.Exe(matar);
            string query = string.Format("delete from Patos where IdDuck = '{0}'",pato.Text);
            con.Open();

          
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            
            con.Close();
            MessageBox.Show("Se dio de baja el pato " + lblnombre.Text);
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
            enable();
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
                lblvolar.Text = dr["Volar"].ToString();
                txtnombre.Text = dr["Nombre"].ToString();
            }
            con.Close();
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            InfoDuck d = new InfoDuck();
            Sqlite s = new Sqlite();

            if (ryes.Checked)
            {
                d.Nada = "Si";
            }
            else if (rno.Checked)
            {
                d.Nada = "No";
            }
            string up = string.Format("update Patos set Nombre = '{0}',Nada = '{1}',Quack='{2}',Volar='{3}' where IdDuck = '{4}'",txtnombre.Text,d.Nada,listaquack.Text,listavolar.Text,pato.Text);
            s.Exe(up);
            string query = string.Format("insert into historial values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", DateTime.Now.ToString("yyyy-MM-dd HH:mm"),txtnombre.Text,listaquack.Text,d.Nada,listavolar.Text,"si",pato.Text);
            s.Exe(query);
            MessageBox.Show("Se registro exitosamente");
        }
        private void volar()
        {
            Ivolar ivolar, novolar, rocket;
            ivolar = new Flyaway();
            novolar = new Nofly();
            rocket = new Rocketpower();
            listavolar.Items.Add(ivolar.Comportamiento());
            listavolar.Items.Add(novolar.Comportamiento());
            listavolar.Items.Add(rocket.Comportamiento());
      
        }
        private void quack()
        {
            IQuack quack, mute, squeak;
            quack = new Quack();
            mute = new Mute();
            squeak = new Squeak();
            string[] l = new string[3] { quack.TypeQuack(), mute.TypeQuack(), squeak.TypeQuack() };
            for (int i = 0; i < 3; i++)
            {
                listaquack.Items.Add(l[i]);
            }
        }
        private void enable()
        {
            txtnombre.Enabled = listaquack.Enabled = listavolar.Enabled = ryes.Enabled = rno.Enabled = btnconfirmar.Enabled = btnkill.Enabled = true;
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        public void tableHis()
        {
               DataSet ds = new DataSet();
         DataTable dt = new DataTable();

        string his = string.Format("select * from historial");
            setcon();
            con.Open();
            cmd = con.CreateCommand();
            string cmdt = "select * from historial";
            db = new SQLiteDataAdapter(cmdt, con);
            ds.Reset();
            db.Fill(ds);
            dt = ds.Tables[0];
            historial.DataSource = dt;
            con.Close();

        }
    }
}
