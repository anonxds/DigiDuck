namespace DigiDuck
{
    partial class Modificar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pato = new System.Windows.Forms.ComboBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblquack = new System.Windows.Forms.Label();
            this.lblnada = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.listavolar = new System.Windows.Forms.ComboBox();
            this.listaquack = new System.Windows.Forms.ComboBox();
            this.ryes = new System.Windows.Forms.RadioButton();
            this.rno = new System.Windows.Forms.RadioButton();
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.lblvolar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnregresar = new System.Windows.Forms.Button();
            this.btnhistorial = new System.Windows.Forms.Button();
            this.filtrar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labNoel10 = new System.Windows.Forms.Label();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.explode = new System.Windows.Forms.Timer(this.components);
            this.Porfiltrar = new System.Windows.Forms.ComboBox();
            this.historial = new MetroFramework.Controls.MetroGrid();
            this.btnsalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ducpic = new System.Windows.Forms.PictureBox();
            this.btnkill = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnemail = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.historial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ducpic)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pato
            // 
            this.pato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pato.FormattingEnabled = true;
            this.pato.Location = new System.Drawing.Point(46, 60);
            this.pato.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pato.Name = "pato";
            this.pato.Size = new System.Drawing.Size(180, 28);
            this.pato.TabIndex = 1;
            this.pato.SelectedIndexChanged += new System.EventHandler(this.pato_SelectedIndexChanged);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(106, 137);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(13, 20);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = " ";
            // 
            // lblquack
            // 
            this.lblquack.AutoSize = true;
            this.lblquack.Location = new System.Drawing.Point(106, 185);
            this.lblquack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblquack.Name = "lblquack";
            this.lblquack.Size = new System.Drawing.Size(13, 20);
            this.lblquack.TabIndex = 3;
            this.lblquack.Text = " ";
            // 
            // lblnada
            // 
            this.lblnada.AutoSize = true;
            this.lblnada.Location = new System.Drawing.Point(106, 234);
            this.lblnada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnada.Name = "lblnada";
            this.lblnada.Size = new System.Drawing.Size(13, 20);
            this.lblnada.TabIndex = 4;
            this.lblnada.Text = " ";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(176, 337);
            this.lblfecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(13, 20);
            this.lblfecha.TabIndex = 5;
            this.lblfecha.Text = " ";
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(46, 525);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(148, 26);
            this.txtnombre.TabIndex = 6;
            // 
            // listavolar
            // 
            this.listavolar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.listavolar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listavolar.Enabled = false;
            this.listavolar.FormattingEnabled = true;
            this.listavolar.Location = new System.Drawing.Point(206, 525);
            this.listavolar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listavolar.Name = "listavolar";
            this.listavolar.Size = new System.Drawing.Size(180, 28);
            this.listavolar.TabIndex = 7;
            // 
            // listaquack
            // 
            this.listaquack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.listaquack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listaquack.Enabled = false;
            this.listaquack.FormattingEnabled = true;
            this.listaquack.Location = new System.Drawing.Point(396, 525);
            this.listaquack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listaquack.Name = "listaquack";
            this.listaquack.Size = new System.Drawing.Size(180, 28);
            this.listaquack.TabIndex = 8;
            this.listaquack.SelectedIndexChanged += new System.EventHandler(this.listaquack_SelectedIndexChanged);
            // 
            // ryes
            // 
            this.ryes.AutoSize = true;
            this.ryes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.ryes.Enabled = false;
            this.ryes.Location = new System.Drawing.Point(606, 531);
            this.ryes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ryes.Name = "ryes";
            this.ryes.Size = new System.Drawing.Size(48, 24);
            this.ryes.TabIndex = 9;
            this.ryes.TabStop = true;
            this.ryes.Text = "Si";
            this.ryes.UseVisualStyleBackColor = false;
            // 
            // rno
            // 
            this.rno.AutoSize = true;
            this.rno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.rno.Enabled = false;
            this.rno.Location = new System.Drawing.Point(698, 531);
            this.rno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rno.Name = "rno";
            this.rno.Size = new System.Drawing.Size(54, 24);
            this.rno.TabIndex = 10;
            this.rno.TabStop = true;
            this.rno.Text = "No";
            this.rno.UseVisualStyleBackColor = false;
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnconfirmar.Enabled = false;
            this.btnconfirmar.Location = new System.Drawing.Point(36, 121);
            this.btnconfirmar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(112, 35);
            this.btnconfirmar.TabIndex = 11;
            this.btnconfirmar.Text = "Confirmar";
            this.btnconfirmar.UseVisualStyleBackColor = false;
            this.btnconfirmar.Click += new System.EventHandler(this.btnconfirmar_Click);
            // 
            // lblvolar
            // 
            this.lblvolar.AutoSize = true;
            this.lblvolar.Location = new System.Drawing.Point(106, 286);
            this.lblvolar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblvolar.Name = "lblvolar";
            this.lblvolar.Size = new System.Drawing.Size(13, 20);
            this.lblvolar.TabIndex = 12;
            this.lblvolar.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 440);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Log";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.label2.Location = new System.Drawing.Point(87, 500);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.label3.Location = new System.Drawing.Point(261, 500);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Volar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.label4.Location = new System.Drawing.Point(447, 500);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Quack";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.label5.Location = new System.Drawing.Point(646, 500);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nadar";
            // 
            // btnregresar
            // 
            this.btnregresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnregresar.Location = new System.Drawing.Point(290, 594);
            this.btnregresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(98, 46);
            this.btnregresar.TabIndex = 18;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.UseVisualStyleBackColor = false;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // btnhistorial
            // 
            this.btnhistorial.Location = new System.Drawing.Point(855, 92);
            this.btnhistorial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnhistorial.Name = "btnhistorial";
            this.btnhistorial.Size = new System.Drawing.Size(138, 35);
            this.btnhistorial.TabIndex = 20;
            this.btnhistorial.Text = "Exportar a PDF";
            this.btnhistorial.UseVisualStyleBackColor = true;
            this.btnhistorial.Click += new System.EventHandler(this.btnhistorial_Click);
            // 
            // filtrar
            // 
            this.filtrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtrar.Enabled = false;
            this.filtrar.FormattingEnabled = true;
            this.filtrar.Location = new System.Drawing.Point(855, 59);
            this.filtrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filtrar.Name = "filtrar";
            this.filtrar.Size = new System.Drawing.Size(180, 28);
            this.filtrar.TabIndex = 22;
            this.filtrar.SelectedIndexChanged += new System.EventHandler(this.filtrar_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 286);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Vuela";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 337);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Fecha de registro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 234);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Nada";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 185);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Quack";
            // 
            // labNoel10
            // 
            this.labNoel10.AutoSize = true;
            this.labNoel10.Location = new System.Drawing.Point(18, 137);
            this.labNoel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labNoel10.Name = "labNoel10";
            this.labNoel10.Size = new System.Drawing.Size(65, 20);
            this.labNoel10.TabIndex = 23;
            this.labNoel10.Text = "Nombre";
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(396, 110);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(94, 46);
            this.btnrefresh.TabIndex = 28;
            this.btnrefresh.Text = "refrescar";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // explode
            // 
            this.explode.Interval = 1200;
            this.explode.Tick += new System.EventHandler(this.explode_Tick);
            // 
            // Porfiltrar
            // 
            this.Porfiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Porfiltrar.FormattingEnabled = true;
            this.Porfiltrar.Location = new System.Drawing.Point(855, 23);
            this.Porfiltrar.Name = "Porfiltrar";
            this.Porfiltrar.Size = new System.Drawing.Size(108, 28);
            this.Porfiltrar.TabIndex = 31;
            this.Porfiltrar.SelectedIndexChanged += new System.EventHandler(this.Porfiltrar_SelectedIndexChanged);
            // 
            // historial
            // 
            this.historial.AllowUserToAddRows = false;
            this.historial.AllowUserToResizeRows = false;
            this.historial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.historial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.historial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.historial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.historial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.historial.DefaultCellStyle = dataGridViewCellStyle11;
            this.historial.EnableHeadersVisualStyles = false;
            this.historial.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.historial.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.historial.Location = new System.Drawing.Point(22, 694);
            this.historial.Name = "historial";
            this.historial.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.historial.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.historial.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.historial.RowTemplate.Height = 28;
            this.historial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.historial.Size = new System.Drawing.Size(1166, 212);
            this.historial.TabIndex = 32;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(1045, 434);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(90, 44);
            this.btnsalir.TabIndex = 33;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(375, 297);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // ducpic
            // 
            this.ducpic.Location = new System.Drawing.Point(375, 90);
            this.ducpic.Name = "ducpic";
            this.ducpic.Size = new System.Drawing.Size(201, 201);
            this.ducpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ducpic.TabIndex = 29;
            this.ducpic.TabStop = false;
            // 
            // btnkill
            // 
            this.btnkill.Enabled = false;
            this.btnkill.Image = global::DigiDuck.Properties.Resources.duck__1_;
            this.btnkill.Location = new System.Drawing.Point(484, 299);
            this.btnkill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnkill.Name = "btnkill";
            this.btnkill.Size = new System.Drawing.Size(119, 74);
            this.btnkill.TabIndex = 0;
            this.btnkill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnkill.UseVisualStyleBackColor = true;
            this.btnkill.Click += new System.EventHandler(this.btnkill_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(48, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(35, 19);
            this.metroLabel1.TabIndex = 34;
            this.metroLabel1.Text = "Pato";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.btnemail);
            this.panel1.Controls.Add(this.Porfiltrar);
            this.panel1.Controls.Add(this.btnhistorial);
            this.panel1.Controls.Add(this.btnrefresh);
            this.panel1.Controls.Add(this.filtrar);
            this.panel1.Controls.Add(this.btnconfirmar);
            this.panel1.Location = new System.Drawing.Point(12, 484);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 191);
            this.panel1.TabIndex = 35;
            // 
            // btnemail
            // 
            this.btnemail.Enabled = false;
            this.btnemail.Location = new System.Drawing.Point(976, 127);
            this.btnemail.Name = "btnemail";
            this.btnemail.Size = new System.Drawing.Size(91, 56);
            this.btnemail.TabIndex = 29;
            this.btnemail.Text = "Mandar por email";
            this.btnemail.UseVisualStyleBackColor = true;
            this.btnemail.Click += new System.EventHandler(this.btnemail_Click);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(755, 142);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(215, 26);
            this.txtemail.TabIndex = 30;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(851, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 20);
            this.label10.TabIndex = 31;
            this.label10.Text = "Filtros";
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(1200, 918);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.historial);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ducpic);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labNoel10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblvolar);
            this.Controls.Add(this.rno);
            this.Controls.Add(this.ryes);
            this.Controls.Add(this.listaquack);
            this.Controls.Add(this.listavolar);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lblnada);
            this.Controls.Add(this.lblquack);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.pato);
            this.Controls.Add(this.btnkill);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Modificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar";
            ((System.ComponentModel.ISupportInitialize)(this.historial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ducpic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnkill;
        private System.Windows.Forms.ComboBox pato;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblquack;
        private System.Windows.Forms.Label lblnada;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.ComboBox listavolar;
        private System.Windows.Forms.ComboBox listaquack;
        private System.Windows.Forms.RadioButton ryes;
        private System.Windows.Forms.RadioButton rno;
        private System.Windows.Forms.Button btnconfirmar;
        private System.Windows.Forms.Label lblvolar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.Button btnhistorial;
        private System.Windows.Forms.ComboBox filtrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labNoel10;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.PictureBox ducpic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer explode;
        private System.Windows.Forms.ComboBox Porfiltrar;
        private MetroFramework.Controls.MetroGrid historial;
        private System.Windows.Forms.Button btnsalir;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnemail;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label10;
    }
}