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
using DigiDuck.Ducks;
using DigiDuck.Properties;

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
            clocks();
            


        }

      
        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtnombre.Text))
                {
                    MessageBox.Show("Pongale un nombre");
                }
                else
                {
                    string query = string.Format("insert into Patos values ('{0}','{1}','{2}','{3}','{4}','{5}')", typeduck.Text, txtnombre.Text, lbltime.Text, lblN.Text, lblQ.Text, lblfly.Text);
                    string historial = string.Format("insert into historial values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", DateTime.Now.ToString("yyyy-MM-dd HH:mm"), txtnombre.Text, lblQ.Text, lblN.Text ,lblfly.Text, lblN.Text, typeduck.Text);
                    s.Exe(query);
                    s.Exe(historial);
                    MessageBox.Show("Se registro exitosamente el pato " + txtnombre.Text);
                    clean();

                    //aun no logro entender a que se refiere con esto?????????

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("El " + typeduck.Text + " pato todavia vive" + ex);
            }
        }

        private void ducks()
        {
            string[] typeducks = new string[5] { "Mallard", "Toy","Decoy","Rubber","Red Head" };
            for (int i = 0; i < 5; i++)
            {
                typeduck.Items.Add(typeducks[i]);
            }
        }

        private void listacomportamiento_SelectedIndexChanged(object sender, EventArgs e)
        {

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
        IQuack quack, squeak, mute;
      
       
        public void clean()
        {
            txtnombre.Text = null;
            listacomportamiento.Text = null;
            listaquack.Text = null;
            typeduck.Text = null;
            ryes.Checked = false;
            Rno.Checked = false;
            lblfly.Text = lblN.Text = lblQ.Text = null;
            btnagregar.Enabled = false;

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
            Iduck iduck;
            switch (typeduck.SelectedIndex)
            {
                case 0:
                    iduck = new Mallard();
                    iduck.TypeDuck(lblQ, lblfly, lblN,duckPic);
                    
                    break;
                case 1:
                    {
                        iduck = new Toy();
                        iduck.TypeDuck(lblQ, lblfly, lblN, duckPic);
                        break;
                    }
                case 2:
                    iduck = new Decoy();

                    iduck.TypeDuck(lblQ, lblfly, lblN, duckPic);
                    break;
                case 3:
                    iduck = new Rubber();
                    iduck.TypeDuck(lblQ, lblfly, lblN, duckPic);
                    break;
                case 4:
                    iduck = new RedHead();
                    iduck.TypeDuck(lblQ, lblfly, lblN, duckPic);
                    break;


            }
        }
        public void dis(){
        btnagregar.Enabled =   txtnombre.Enabled = true;
        }

        private void AddDuck_Load(object sender, EventArgs e)
        {

        }

        private void btnterminar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void en()
        {
            btnagregar.Enabled = txtnombre.Enabled = listacomportamiento.Enabled = listaquack.Enabled = ryes.Enabled = Rno.Enabled = false;

        }

        private void listaquack_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listaquack.SelectedIndex)
            {
                case 0:
                    quack = new Quack();
                    quack.Typesound();
                    break;
                case 1:

                    break;
                case 2:
                    squeak = new Squeak();
                    squeak.Typesound();
                 
                    break;
            }
        }
       
       
    }
}
