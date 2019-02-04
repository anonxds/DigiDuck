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
                        d.Nada = "yes";
                    }
                    else if (Rno.Checked)
                    {
                        d.Nada = "No";
                    }
                    string query = string.Format("insert into Patos values ('{0}','{1}','{2}','{3}','{4}')", typeduck.Text, txtnombre.Text, lbltime.Text, d.Nada,listaquack.Text);
               
                    s.Exe(query);
                
                }
             
                
            }
            catch
            {
                MessageBox.Show("Este pato todavia vive");
            }
        }
       
        private void ducks()
        {
            string[] typeducks = new string[5] {"Mallard","Red head","Decoy","Toy","Rubber"};
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
            Ivolar ivolar,novolar,rocket;
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
            
            IQuack quack,squeak,mute;
            Setgraz s = new Setgraz();
            mute = new Mute();

            quack = new Quack();
            squeak = new Squeak();

           
           listaquack.Items.Add(quack.TypeQuack());
            listaquack.Items.Add(mute.TypeQuack());
            listaquack.Items.Add(squeak.TypeQuack());
            
            
            
        }
     

    }
}
