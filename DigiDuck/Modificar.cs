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
using DigiDuck.Filtros;
using DigiDuck.picstrategy;
using System.Media;
using System.Net.Mail;
using System.Net;

namespace DigiDuck
{
    public partial class Modificar : Form
    {
       SQLiteConnection con = new SQLiteConnection("Data Source=./Patos.sqlite3;Version=3;New=False;Compress=true;");
        private SQLiteCommand cmd;
        private SQLiteDataAdapter db;
        InfoDuck d = new InfoDuck();
        public Modificar()
        {
            InitializeComponent();
            fillducks();
            volar();
            d.quack(listaquack);
            tableHis();
            filtros();
        }
      

        private void btnkill_Click(object sender, EventArgs e)
        {try
            {
             
                Sqlite s = new Sqlite();
                string matar = string.Format("insert into historial (Fecha,Nombre,Vive,Tipo) values ('{0}','{1}','{2}','{3}')", DateTime.Now.ToString("yyyy-MM-dd HH:mm"), txtnombre.Text, "No", pato.Text);
                s.Exe(matar);
                string query = string.Format("delete from Patos where IdDuck = '{0}'", pato.Text);
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                pictureBox1.Image = Properties.Resources.explode;
                explode.Start();
                con.Close();
                clean();
                Stream stream = Properties.Resources.Shotgun_Pump;
                SoundPlayer v = new SoundPlayer(stream);
                v.Play();
                MessageBox.Show("Se dio de baja el pato " + lblnombre.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("El pato ya se dio de baja");
            }
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
            showpic();
         
        }
        public void showpic()
        {
            explode.Stop();
            Metodo m = new Metodo();
            m.spic(ducpic);
            pictureBox1.Image = Properties.Resources.pixelheart;
            switch (pato.Text)
            {
                case "Red Head":
                    m.Setpic(new setRedhead());
                    m.show();
                    break;
                case "Mallard":
                    m.Setpic(new Setype());
                    m.show();
                    break;
                case "Rubber":
                    m.Setpic(new setRubber());
                    m.show();
                    break;
                case "Toy":
                    m.Setpic(new Settrum());
                    m.show();
                    break;
                case "Decoy":
                    m.Setpic(new setDecoy());
                    m.show();
                    break;
            }
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
            
            Sqlite s = new Sqlite();

            if (ryes.Checked)
            {
                d.Nada = "Si";
            }
            else if (rno.Checked)
            {
                d.Nada = "No";
            }
            if (listaquack.Text == "" || listavolar.Text == "" || ryes.Checked == false && rno.Checked == false)
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
                tableHis();
                clean();
            }

        }
        public void clean()
        {

            listavolar.Text = null;
            listaquack.Text = null;
            txtnombre.Text   = lblfecha.Text = lblnada.Text = lblnombre.Text = lblquack.Text = lblvolar.Text = "";
            btnconfirmar.Enabled = btnkill.Enabled = false;
            ryes.Checked = rno.Checked = false;
            ducpic.Image = null;
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
        public void filtros()
        {
          
            string[] por = new string[] {"Por tipo","Por Vida","Por volar","Por Graznar","Por Nadar" };
            for (int i = 0; i < 5; i++)
            {
                Porfiltrar.Items.Add(por[i]);
            }
        }
        IFiltro filtro;
        public void fil()
        {
         //opcion de usar el metodo estrategia
            switch (filtrar.Text)
            {
                case "Viven":
            
                    filtro = new PorVida();
                    filtro.Filtrar(historial);
                    break;
                case "No viven":
                    filtro = new PorSinvida();
                    filtro.Filtrar(historial);
                    break;
                case "Mallard":
                    filtro = new PorMallard();
                    filtro.Filtrar(historial);
                    break;
                case "Decoy":
                    filtro = new Pordecoy();
                    filtro.Filtrar(historial);
                    break;
                case "Red Head":
                    filtro = new Portredhead();
                    filtro.Filtrar(historial);
                    break;
                case "Toy":
                    filtro = new Portoy();
                    filtro.Filtrar(historial);
                    break;
                case "Rubber":
                    filtro = new Porrubber();
                    filtro.Filtrar(historial);
                    break;
                case "Vuelan":
                    filtro = new Porvolar();
                    filtro.Filtrar(historial);
                    break;
                case "No vuelan":
                    filtro = new Pornovolar();
                    filtro.Filtrar(historial);
                    break;
                case "Tienen cohetes":
                    filtro = new Porcohetes();
                    filtro.Filtrar(historial);
                    break;
                case "Quack":
                    filtro = new PorQuack();
                    filtro.Filtrar(historial);
                    break;
                case "Squeak":
                    filtro = new Squeaks();
                    filtro.Filtrar(historial);
                    break;
                case "Nadar":
                    filtro = new PorNadar();
                    filtro.Filtrar(historial);
                break;
                case ".........":
                    filtro = new Pormute();
                    filtro.Filtrar(historial);
                    break;


            }
        }

        private void filtrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            fil();
        }
        public void volar()
        {
            Sqlite s = new Sqlite();
            s._volar(listavolar);
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            tableHis();
        }

        private void explode_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void Porfiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrar.Items.Clear();
            filtrar.Enabled = true;
            switch (Porfiltrar.Text)
            {
                case "Por tipo":
                    string[] fil = new string[5] {"Mallard", "Decoy", "Red Head", "Toy", "Rubber"};
                    for (int i = 0; i < 5; i++)
                    {
                        filtrar.Items.Add(fil[i]);
                    }
                    break;
                case "Por Vida":
                    string[] vida = new string[2] { "Viven", "No viven"};
                    for (int i = 0; i < 2; i++)
                    {
                        filtrar.Items.Add(vida[i]);
                    }
                    break;
                case "Por volar":
                    string[] volar = new string[3] { "Vuelan", "No vuelan", "Tienen cohetes"};
                    for (int i = 0; i < 3; i++)
                    {
                        filtrar.Items.Add(volar[i]);
                    }
                    break;
                case "Por Graznar":
                    string[] graz = new string[3] { "Quack", "Squeak","........." };
                    for (int i = 0; i < 3; i++)
                    {
                        filtrar.Items.Add(graz[i]);
                    }
                    break;
                case "Por Nadar":
                    filtrar.Items.Add("Nadar");
                    break;




            }
        }

        private void listaquack_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnemail_Click(object sender, EventArgs e)
        {
            try
            {
            



                BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
                PdfPTable pdfPTable = new PdfPTable(historial.Columns.Count);
                pdfPTable.DefaultCell.Padding = 3;
                pdfPTable.WidthPercentage = 100;
                pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfPTable.DefaultCell.BorderWidth = 1;
                iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
                foreach (DataGridViewColumn column in historial.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    pdfPTable.AddCell(cell);
                }
                foreach (DataGridViewRow row in historial.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdfPTable.AddCell(new Phrase(cell.Value.ToString(), text));
                    }
                }



                Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                MemoryStream memoryStream2 = new MemoryStream();
                PdfWriter write = PdfWriter.GetInstance(pdfdoc, memoryStream2);

                pdfdoc.Open();
                pdfdoc.Add(pdfPTable);
                write.CloseStream = false;
                pdfdoc.Close();
                memoryStream2.Position = 0;





                MailMessage mail = new MailMessage("bejeweler2@gmail.com", txtemail.Text, "Reticula", "Listado de patos");
                mail.Attachments.Add(new Attachment(memoryStream2, "Ducks.pdf"));
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential("bejeweler2@gmail.com", "bejeweled2012");
                client.EnableSsl = true;
                client.Send(mail);
                btnemail.Enabled = false;
                txtemail.Text = "";
                MessageBox.Show("Mensaje enviado");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hubo un error "+ex);
            }


            
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            btnemail.Enabled = true;
            if (string.IsNullOrWhiteSpace(txtemail.Text))
            {
                btnemail.Enabled = false;
            }
        }
    }
}
