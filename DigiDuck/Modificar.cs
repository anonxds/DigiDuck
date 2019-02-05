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
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

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
            filtros();
        }

        private void btnkill_Click(object sender, EventArgs e)
        {
            InfoDuck d = new InfoDuck();
            Sqlite s = new Sqlite();
            string matar = string.Format("insert into historial (Fecha,Nombre,Vive,Tipo) values ('{0}','{1}','{2}','{3}')", DateTime.Now.ToString("yyyy-MM-dd HH:mm"), txtnombre.Text, "No", pato.Text);
            s.Exe(matar);
            string query = string.Format("delete from Patos where IdDuck = '{0}'",pato.Text);
            con.Open();

          
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            
            con.Close();
            clean();
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
                listaquack.Text = dr["Quack"].ToString();
                listavolar.Text = dr["Volar"].ToString();
                
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
            if (listaquack.Text == "" || listavolar.Text == "")
            {
                MessageBox.Show("Anade un comportamiento");

            }
            else
            {

                string up = string.Format("update Patos set Nombre = '{0}',Nada = '{1}',Quack='{2}',Volar='{3}' where IdDuck = '{4}'", txtnombre.Text, d.Nada, listaquack.Text, listavolar.Text, pato.Text);
                s.Exe(up);
                string query = string.Format("insert into historial values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", DateTime.Now.ToString("yyyy-MM-dd HH:mm"), txtnombre.Text, listaquack.Text, d.Nada, listavolar.Text, "si", pato.Text);
                s.Exe(query);
                MessageBox.Show("Se registro exitosamente");
            }

        }
        public void clean()
        {

            listavolar.Text = null;
            listaquack.Text = null;
            pato.Text = null;
            txtnombre.Text   = lblfecha.Text = lblnada.Text = lblnombre.Text = lblquack.Text = lblvolar.Text = "";
            
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

        //
       public  void ExportDataTableToPdf(DataGridView dgw, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdfPTable = new PdfPTable(dgw.Columns.Count);
            pdfPTable.DefaultCell.Padding = 3;
            pdfPTable.WidthPercentage = 100;
            pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfPTable.DefaultCell.BorderWidth = 1;
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            foreach(DataGridViewColumn column in dgw.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240,240,240);
                pdfPTable.AddCell(cell);
            }
            foreach(DataGridViewRow row in dgw.Rows)
            {
                foreach(DataGridViewCell cell in row.Cells)
                {
                    pdfPTable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }
            var saveFilediloge = new SaveFileDialog();
            saveFilediloge.FileName = filename;
            saveFilediloge.DefaultExt = ".pdf";
            if (saveFilediloge.ShowDialog() == DialogResult.OK)
            {
                using(FileStream stream = new FileStream(saveFilediloge.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdfPTable);
                    pdfdoc.Close();
                    stream.Close();
                }
            }
          
        }

        private void btnhistorial_Click(object sender, EventArgs e)
        {
            ExportDataTableToPdf(historial, "memes");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        public void filtros()
        {
            string[] fil = new string[5] {"Viven","No viven","Mallard","Decoy","Red Head" };
            for (int i = 0; i < 5; i++)
            {
                filtrar.Items.Add(fil[i]);
            }

         

           


        }
        public void fil()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();


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

            //opcion de usar el metodo estrategia
            switch (filtrar.SelectedIndex)
            {
                case 0:
                    DataView dv = new DataView(dt, "Vive='Si'", "Vive desc", DataViewRowState.CurrentRows);
                    historial.DataSource = dv;
                    break;
                case 1:
                    DataView dc = new DataView(dt, "Vive='No'", "Vive desc", DataViewRowState.CurrentRows);
                    historial.DataSource = dc;
                    break;
                case 2:
                    DataView dx = new DataView(dt, "Tipo='Mallard'", "Vive desc", DataViewRowState.CurrentRows);
                    historial.DataSource = dx;
                    break;
                case 3:
                    DataView da = new DataView(dt, "Tipo='Decoy'", "Vive desc", DataViewRowState.CurrentRows);
                    historial.DataSource = da;
                    break;
                case 4:
                    DataView dq = new DataView(dt, "Tipo='Red head'", "Vive desc", DataViewRowState.CurrentRows);
                    historial.DataSource = dq;
                    break;

            }
        }

        private void filtrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            fil();
        }
    }
}
