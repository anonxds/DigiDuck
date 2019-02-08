namespace DigiDuck
{
    partial class AddDuck
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
            this.typeduck = new System.Windows.Forms.ComboBox();
            this.lbltime = new System.Windows.Forms.Label();
            this.hora = new System.Windows.Forms.Label();
            this.listacomportamiento = new System.Windows.Forms.ComboBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblcomportamiento = new System.Windows.Forms.Label();
            this.lbnombre = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.lblquack = new System.Windows.Forms.Label();
            this.listaquack = new System.Windows.Forms.ComboBox();
            this.lblswim = new System.Windows.Forms.Label();
            this.ryes = new System.Windows.Forms.RadioButton();
            this.Rno = new System.Windows.Forms.RadioButton();
            this.btnreturn = new System.Windows.Forms.Button();
            this.lblQ = new System.Windows.Forms.Label();
            this.lblfly = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.duckPic = new System.Windows.Forms.PictureBox();
            this.btnterminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.duckPic)).BeginInit();
            this.SuspendLayout();
            // 
            // typeduck
            // 
            this.typeduck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeduck.FormattingEnabled = true;
            this.typeduck.Location = new System.Drawing.Point(129, 55);
            this.typeduck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.typeduck.Name = "typeduck";
            this.typeduck.Size = new System.Drawing.Size(180, 28);
            this.typeduck.TabIndex = 0;
            this.typeduck.SelectedIndexChanged += new System.EventHandler(this.typeduck_SelectedIndexChanged);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(542, 120);
            this.lbltime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(123, 20);
            this.lbltime.TabIndex = 1;
            this.lbltime.Text = "Hora de registro";
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.Location = new System.Drawing.Point(542, 60);
            this.hora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(61, 20);
            this.hora.TabIndex = 2;
            this.hora.Text = "Tiempo";
            // 
            // listacomportamiento
            // 
            this.listacomportamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listacomportamiento.Enabled = false;
            this.listacomportamiento.FormattingEnabled = true;
            this.listacomportamiento.Location = new System.Drawing.Point(747, 365);
            this.listacomportamiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listacomportamiento.Name = "listacomportamiento";
            this.listacomportamiento.Size = new System.Drawing.Size(180, 28);
            this.listacomportamiento.TabIndex = 3;
            this.listacomportamiento.Visible = false;
            this.listacomportamiento.SelectedIndexChanged += new System.EventHandler(this.listacomportamiento_SelectedIndexChanged);
            // 
            // btnagregar
            // 
            this.btnagregar.Enabled = false;
            this.btnagregar.Location = new System.Drawing.Point(33, 365);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(112, 35);
            this.btnagregar.TabIndex = 4;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(18, 60);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(98, 20);
            this.lblnombre.TabIndex = 5;
            this.lblnombre.Text = "Tipo de Pato";
            // 
            // lblcomportamiento
            // 
            this.lblcomportamiento.AutoSize = true;
            this.lblcomportamiento.Location = new System.Drawing.Point(13, 182);
            this.lblcomportamiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcomportamiento.Name = "lblcomportamiento";
            this.lblcomportamiento.Size = new System.Drawing.Size(164, 20);
            this.lblcomportamiento.TabIndex = 6;
            this.lblcomportamiento.Text = "Comportamiento volar";
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Location = new System.Drawing.Point(18, 120);
            this.lbnombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(65, 20);
            this.lbnombre.TabIndex = 7;
            this.lbnombre.Text = "Nombre";
            // 
            // txtnombre
            // 
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(138, 117);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnombre.MaxLength = 20;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(148, 26);
            this.txtnombre.TabIndex = 8;
            // 
            // clock
            // 
            this.clock.Interval = 1000;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // lblquack
            // 
            this.lblquack.AutoSize = true;
            this.lblquack.Location = new System.Drawing.Point(13, 251);
            this.lblquack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblquack.Name = "lblquack";
            this.lblquack.Size = new System.Drawing.Size(71, 20);
            this.lblquack.TabIndex = 9;
            this.lblquack.Text = "Grazna?";
            // 
            // listaquack
            // 
            this.listaquack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listaquack.Enabled = false;
            this.listaquack.FormattingEnabled = true;
            this.listaquack.Location = new System.Drawing.Point(747, 392);
            this.listaquack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listaquack.Name = "listaquack";
            this.listaquack.Size = new System.Drawing.Size(180, 28);
            this.listaquack.TabIndex = 10;
            this.listaquack.Visible = false;
            this.listaquack.SelectedIndexChanged += new System.EventHandler(this.listaquack_SelectedIndexChanged);
            // 
            // lblswim
            // 
            this.lblswim.AutoSize = true;
            this.lblswim.Location = new System.Drawing.Point(18, 314);
            this.lblswim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblswim.Name = "lblswim";
            this.lblswim.Size = new System.Drawing.Size(52, 20);
            this.lblswim.TabIndex = 11;
            this.lblswim.Text = "Nadar";
            // 
            // ryes
            // 
            this.ryes.AutoSize = true;
            this.ryes.Enabled = false;
            this.ryes.Location = new System.Drawing.Point(764, 295);
            this.ryes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ryes.Name = "ryes";
            this.ryes.Size = new System.Drawing.Size(48, 24);
            this.ryes.TabIndex = 12;
            this.ryes.TabStop = true;
            this.ryes.Text = "Si";
            this.ryes.UseVisualStyleBackColor = true;
            this.ryes.Visible = false;
            // 
            // Rno
            // 
            this.Rno.AutoSize = true;
            this.Rno.Enabled = false;
            this.Rno.Location = new System.Drawing.Point(860, 295);
            this.Rno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Rno.Name = "Rno";
            this.Rno.Size = new System.Drawing.Size(54, 24);
            this.Rno.TabIndex = 13;
            this.Rno.TabStop = true;
            this.Rno.Text = "No";
            this.Rno.UseVisualStyleBackColor = true;
            this.Rno.Visible = false;
            // 
            // btnreturn
            // 
            this.btnreturn.Location = new System.Drawing.Point(174, 365);
            this.btnreturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(112, 35);
            this.btnreturn.TabIndex = 14;
            this.btnreturn.Text = "Regresar";
            this.btnreturn.UseVisualStyleBackColor = true;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Location = new System.Drawing.Point(145, 251);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(13, 20);
            this.lblQ.TabIndex = 15;
            this.lblQ.Text = " ";
            // 
            // lblfly
            // 
            this.lblfly.AutoSize = true;
            this.lblfly.Location = new System.Drawing.Point(211, 182);
            this.lblfly.Name = "lblfly";
            this.lblfly.Size = new System.Drawing.Size(13, 20);
            this.lblfly.TabIndex = 16;
            this.lblfly.Text = " ";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(86, 314);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(13, 20);
            this.lblN.TabIndex = 17;
            this.lblN.Text = " ";
            // 
            // duckPic
            // 
            this.duckPic.Location = new System.Drawing.Point(355, 55);
            this.duckPic.Name = "duckPic";
            this.duckPic.Size = new System.Drawing.Size(180, 178);
            this.duckPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.duckPic.TabIndex = 18;
            this.duckPic.TabStop = false;
            // 
            // btnterminar
            // 
            this.btnterminar.Location = new System.Drawing.Point(594, 387);
            this.btnterminar.Name = "btnterminar";
            this.btnterminar.Size = new System.Drawing.Size(85, 35);
            this.btnterminar.TabIndex = 19;
            this.btnterminar.Text = "Salir";
            this.btnterminar.UseVisualStyleBackColor = true;
            this.btnterminar.Click += new System.EventHandler(this.btnterminar_Click);
            // 
            // AddDuck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(691, 434);
            this.Controls.Add(this.btnterminar);
            this.Controls.Add(this.duckPic);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.lblfly);
            this.Controls.Add(this.lblQ);
            this.Controls.Add(this.btnreturn);
            this.Controls.Add(this.Rno);
            this.Controls.Add(this.ryes);
            this.Controls.Add(this.lblswim);
            this.Controls.Add(this.listaquack);
            this.Controls.Add(this.lblquack);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lbnombre);
            this.Controls.Add(this.lblcomportamiento);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.listacomportamiento);
            this.Controls.Add(this.hora);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.typeduck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddDuck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDuck";
            this.Load += new System.EventHandler(this.AddDuck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.duckPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox typeduck;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.ComboBox listacomportamiento;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblcomportamiento;
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.Label lblquack;
        private System.Windows.Forms.ComboBox listaquack;
        private System.Windows.Forms.Label lblswim;
        private System.Windows.Forms.RadioButton ryes;
        private System.Windows.Forms.RadioButton Rno;
        private System.Windows.Forms.Button btnreturn;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.Label lblfly;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.PictureBox duckPic;
        private System.Windows.Forms.Button btnterminar;
    }
}