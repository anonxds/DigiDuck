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
using System.Media;
using System.IO;

namespace DigiDuck
{
    public partial class AddDuck : Form
    {

        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        Sqlite s = new Sqlite();

        public AddDuck()
        {
            InitializeComponent();
            ducks();
            volar();
            clocks();
            test();
           
        }

        InfoDuck d = new InfoDuck();

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtnombre.Text))
                {
                    MessageBox.Show("por favor llene los datos");
                }
                else
                {
                    InfoDuck d = new InfoDuck();
                    if (ryes.Checked)
                    {
                        d.Nada = "Si";
                    }
                    else if (Rno.Checked)
                    {
                        d.Nada = "No";
                    }
                    string query = string.Format("insert into Patos values ('{0}','{1}','{2}','{3}','{4}','{5}')", typeduck.Text, txtnombre.Text, lbltime.Text, d.Nada, listaquack.Text, listacomportamiento.Text);
                    string historial = string.Format("insert into historial values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", DateTime.Now.ToString("yyyy-MM-dd HH:mm"), txtnombre.Text, listaquack.Text, d.Nada, listacomportamiento.Text, "Si", typeduck.Text);


                    s.Exe(query);
                    s.Exe(historial);
                    MessageBox.Show("Se registro exitosamente el pato " + txtnombre.Text);
                    clean();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("El " + typeduck.Text + " pato todavia vive" + ex);
            }
        }

        private void ducks()
        {
            string[] typeducks = new string[5] { "Mallard", "Red head", "Decoy", "Toy", "Rubber" };
            for (int i = 0; i < 5; i++)
            {
                typeduck.Items.Add(typeducks[i]);
            }
        }

        private void listacomportamiento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void volar()
        {
            Ivolar ivolar, novolar, rocket;
            ivolar = new Flyaway();
            novolar = new Nofly();
            rocket = new Rocketpower();
            listacomportamiento.Items.Add(ivolar.Comportamiento());
            listacomportamiento.Items.Add(novolar.Comportamiento());
            listacomportamiento.Items.Add(rocket.Comportamiento());

        }

        private void clock_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongTimeString();
            clock.Start();
        }
        private void clocks()
        {
            lbltime.Text = DateTime.Now.ToString("yyyy-MM-dd");
            clock.Start();
            lbltime.Text = DateTime.Now.ToLongTimeString();
        }
        public void test()
        {

            IQuack quack, squeak, mute;
            Setgraz s = new Setgraz();
            mute = new Mute();

            quack = new Quack();
            squeak = new Squeak();


            listaquack.Items.Add(quack.TypeQuack());
            listaquack.Items.Add(mute.TypeQuack());
            listaquack.Items.Add(squeak.TypeQuack());



        }
        public void clean()
        {
            txtnombre.Text = null;
            listacomportamiento.Text = null;
            listaquack.Text = null;
            typeduck.Text = null;
            ryes.Checked = false;
            Rno.Checked = false;


        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void typeduck_SelectedIndexChanged(object sender, EventArgs e)
        {
            dis();
        }
        public void dis(){
          btnagregar.Enabled=  txtnombre.Enabled = listacomportamiento.Enabled = listaquack.Enabled = ryes.Enabled = Rno.Enabled = true;
       }

        private void listaquack_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listaquack.SelectedIndex)
            {
                case 0:
                    quack();
                    break;
                case 1:

                    break;
                case 2:
                    clown();
                    break;
            }
        }
        public void quack()
        {
            Stream str = Properties.Resources.quack;
            SoundPlayer s = new SoundPlayer(str);
            s.Play();
        }
        public void clown()
        {
            Stream stream = Properties.Resources.clown;
            SoundPlayer s = new SoundPlayer(stream);
            s.Play();
        }
        
    }
}
