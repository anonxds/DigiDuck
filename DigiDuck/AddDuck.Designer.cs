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
            this.SuspendLayout();
            // 
            // typeduck
            // 
            this.typeduck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeduck.FormattingEnabled = true;
            this.typeduck.Location = new System.Drawing.Point(86, 36);
            this.typeduck.Name = "typeduck";
            this.typeduck.Size = new System.Drawing.Size(121, 21);
            this.typeduck.TabIndex = 0;
            this.typeduck.SelectedIndexChanged += new System.EventHandler(this.typeduck_SelectedIndexChanged);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(289, 75);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(82, 13);
            this.lbltime.TabIndex = 1;
            this.lbltime.Text = "Hora de registro";
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.Location = new System.Drawing.Point(289, 36);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(42, 13);
            this.hora.TabIndex = 2;
            this.hora.Text = "Tiempo";
            // 
            // listacomportamiento
            // 
            this.listacomportamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listacomportamiento.Enabled = false;
            this.listacomportamiento.FormattingEnabled = true;
            this.listacomportamiento.Location = new System.Drawing.Point(127, 115);
            this.listacomportamiento.Name = "listacomportamiento";
            this.listacomportamiento.Size = new System.Drawing.Size(121, 21);
            this.listacomportamiento.TabIndex = 3;
            this.listacomportamiento.SelectedIndexChanged += new System.EventHandler(this.listacomportamiento_SelectedIndexChanged);
            // 
            // btnagregar
            // 
            this.btnagregar.Enabled = false;
            this.btnagregar.Location = new System.Drawing.Point(22, 237);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 4;
            this.btnagregar.Text = "agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(12, 39);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(68, 13);
            this.lblnombre.TabIndex = 5;
            this.lblnombre.Text = "Tipo de Pato";
            // 
            // lblcomportamiento
            // 
            this.lblcomportamiento.AutoSize = true;
            this.lblcomportamiento.Location = new System.Drawing.Point(12, 118);
            this.lblcomportamiento.Name = "lblcomportamiento";
            this.lblcomportamiento.Size = new System.Drawing.Size(109, 13);
            this.lblcomportamiento.TabIndex = 6;
            this.lblcomportamiento.Text = "Comportamiento volar";
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Location = new System.Drawing.Point(36, 78);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(44, 13);
            this.lbnombre.TabIndex = 7;
            this.lbnombre.Text = "Nombre";
            // 
            // txtnombre
            // 
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(86, 75);
            this.txtnombre.MaxLength = 20;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
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
            this.lblquack.Location = new System.Drawing.Point(33, 163);
            this.lblquack.Name = "lblquack";
            this.lblquack.Size = new System.Drawing.Size(47, 13);
            this.lblquack.TabIndex = 9;
            this.lblquack.Text = "Grazna?";
            // 
            // listaquack
            // 
            this.listaquack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listaquack.Enabled = false;
            this.listaquack.FormattingEnabled = true;
            this.listaquack.Location = new System.Drawing.Point(86, 160);
            this.listaquack.Name = "listaquack";
            this.listaquack.Size = new System.Drawing.Size(121, 21);
            this.listaquack.TabIndex = 10;
            this.listaquack.SelectedIndexChanged += new System.EventHandler(this.listaquack_SelectedIndexChanged);
            // 
            // lblswim
            // 
            this.lblswim.AutoSize = true;
            this.lblswim.Location = new System.Drawing.Point(12, 204);
            this.lblswim.Name = "lblswim";
            this.lblswim.Size = new System.Drawing.Size(36, 13);
            this.lblswim.TabIndex = 11;
            this.lblswim.Text = "Nadar";
            // 
            // ryes
            // 
            this.ryes.AutoSize = true;
            this.ryes.Enabled = false;
            this.ryes.Location = new System.Drawing.Point(63, 204);
            this.ryes.Name = "ryes";
            this.ryes.Size = new System.Drawing.Size(34, 17);
            this.ryes.TabIndex = 12;
            this.ryes.TabStop = true;
            this.ryes.Text = "Si";
            this.ryes.UseVisualStyleBackColor = true;
            // 
            // Rno
            // 
            this.Rno.AutoSize = true;
            this.Rno.Enabled = false;
            this.Rno.Location = new System.Drawing.Point(127, 204);
            this.Rno.Name = "Rno";
            this.Rno.Size = new System.Drawing.Size(39, 17);
            this.Rno.TabIndex = 13;
            this.Rno.TabStop = true;
            this.Rno.Text = "No";
            this.Rno.UseVisualStyleBackColor = true;
            // 
            // btnreturn
            // 
            this.btnreturn.Location = new System.Drawing.Point(191, 237);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(75, 23);
            this.btnreturn.TabIndex = 14;
            this.btnreturn.Text = "Regresar";
            this.btnreturn.UseVisualStyleBackColor = true;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // AddDuck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 282);
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
            this.Name = "AddDuck";
            this.Text = "AddDuck";
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
    }
}