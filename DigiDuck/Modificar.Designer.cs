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
            this.btnkill = new System.Windows.Forms.Button();
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
            this.historial = new System.Windows.Forms.DataGridView();
            this.btnhistorial = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.filtrar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labNoel10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.historial)).BeginInit();
            this.SuspendLayout();
            // 
            // btnkill
            // 
            this.btnkill.Enabled = false;
            this.btnkill.Location = new System.Drawing.Point(264, 184);
            this.btnkill.Name = "btnkill";
            this.btnkill.Size = new System.Drawing.Size(104, 48);
            this.btnkill.TabIndex = 0;
            this.btnkill.Text = "Dar de baja el pato";
            this.btnkill.UseVisualStyleBackColor = true;
            this.btnkill.Click += new System.EventHandler(this.btnkill_Click);
            // 
            // pato
            // 
            this.pato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pato.FormattingEnabled = true;
            this.pato.Location = new System.Drawing.Point(31, 39);
            this.pato.Name = "pato";
            this.pato.Size = new System.Drawing.Size(121, 21);
            this.pato.TabIndex = 1;
            this.pato.SelectedIndexChanged += new System.EventHandler(this.pato_SelectedIndexChanged);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(71, 89);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(10, 13);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = " ";
            // 
            // lblquack
            // 
            this.lblquack.AutoSize = true;
            this.lblquack.Location = new System.Drawing.Point(71, 120);
            this.lblquack.Name = "lblquack";
            this.lblquack.Size = new System.Drawing.Size(10, 13);
            this.lblquack.TabIndex = 3;
            this.lblquack.Text = " ";
            // 
            // lblnada
            // 
            this.lblnada.AutoSize = true;
            this.lblnada.Location = new System.Drawing.Point(71, 152);
            this.lblnada.Name = "lblnada";
            this.lblnada.Size = new System.Drawing.Size(10, 13);
            this.lblnada.TabIndex = 4;
            this.lblnada.Text = " ";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(117, 219);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(10, 13);
            this.lblfecha.TabIndex = 5;
            this.lblfecha.Text = " ";
            // 
            // txtnombre
            // 
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(31, 341);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 6;
            // 
            // listavolar
            // 
            this.listavolar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listavolar.Enabled = false;
            this.listavolar.FormattingEnabled = true;
            this.listavolar.Location = new System.Drawing.Point(137, 341);
            this.listavolar.Name = "listavolar";
            this.listavolar.Size = new System.Drawing.Size(121, 21);
            this.listavolar.TabIndex = 7;
            // 
            // listaquack
            // 
            this.listaquack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listaquack.Enabled = false;
            this.listaquack.FormattingEnabled = true;
            this.listaquack.Location = new System.Drawing.Point(264, 341);
            this.listaquack.Name = "listaquack";
            this.listaquack.Size = new System.Drawing.Size(121, 21);
            this.listaquack.TabIndex = 8;
            // 
            // ryes
            // 
            this.ryes.AutoSize = true;
            this.ryes.Enabled = false;
            this.ryes.Location = new System.Drawing.Point(404, 345);
            this.ryes.Name = "ryes";
            this.ryes.Size = new System.Drawing.Size(34, 17);
            this.ryes.TabIndex = 9;
            this.ryes.TabStop = true;
            this.ryes.Text = "Si";
            this.ryes.UseVisualStyleBackColor = true;
            // 
            // rno
            // 
            this.rno.AutoSize = true;
            this.rno.Enabled = false;
            this.rno.Location = new System.Drawing.Point(465, 345);
            this.rno.Name = "rno";
            this.rno.Size = new System.Drawing.Size(39, 17);
            this.rno.TabIndex = 10;
            this.rno.TabStop = true;
            this.rno.Text = "No";
            this.rno.UseVisualStyleBackColor = true;
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.Enabled = false;
            this.btnconfirmar.Location = new System.Drawing.Point(31, 386);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnconfirmar.TabIndex = 11;
            this.btnconfirmar.Text = "Confirmar";
            this.btnconfirmar.UseVisualStyleBackColor = true;
            this.btnconfirmar.Click += new System.EventHandler(this.btnconfirmar_Click);
            // 
            // lblvolar
            // 
            this.lblvolar.AutoSize = true;
            this.lblvolar.Location = new System.Drawing.Point(71, 186);
            this.lblvolar.Name = "lblvolar";
            this.lblvolar.Size = new System.Drawing.Size(10, 13);
            this.lblvolar.TabIndex = 12;
            this.lblvolar.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Log";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Volar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Quack";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nada";
            // 
            // btnregresar
            // 
            this.btnregresar.Location = new System.Drawing.Point(193, 386);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(65, 30);
            this.btnregresar.TabIndex = 18;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // historial
            // 
            this.historial.AllowUserToAddRows = false;
            this.historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historial.Location = new System.Drawing.Point(23, 430);
            this.historial.Name = "historial";
            this.historial.Size = new System.Drawing.Size(765, 150);
            this.historial.TabIndex = 19;
            // 
            // btnhistorial
            // 
            this.btnhistorial.Location = new System.Drawing.Point(607, 401);
            this.btnhistorial.Name = "btnhistorial";
            this.btnhistorial.Size = new System.Drawing.Size(92, 23);
            this.btnhistorial.TabIndex = 20;
            this.btnhistorial.Text = "Exportar a PDF";
            this.btnhistorial.UseVisualStyleBackColor = true;
            this.btnhistorial.Click += new System.EventHandler(this.btnhistorial_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(624, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // filtrar
            // 
            this.filtrar.FormattingEnabled = true;
            this.filtrar.Location = new System.Drawing.Point(578, 374);
            this.filtrar.Name = "filtrar";
            this.filtrar.Size = new System.Drawing.Size(121, 21);
            this.filtrar.TabIndex = 22;
            this.filtrar.SelectedIndexChanged += new System.EventHandler(this.filtrar_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Vuela";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Fecha de registro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Nada";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Quack";
            // 
            // labNoel10
            // 
            this.labNoel10.AutoSize = true;
            this.labNoel10.Location = new System.Drawing.Point(12, 89);
            this.labNoel10.Name = "labNoel10";
            this.labNoel10.Size = new System.Drawing.Size(44, 13);
            this.labNoel10.TabIndex = 23;
            this.labNoel10.Text = "Nombre";
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 592);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labNoel10);
            this.Controls.Add(this.filtrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnhistorial);
            this.Controls.Add(this.historial);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblvolar);
            this.Controls.Add(this.btnconfirmar);
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
            this.Name = "Modificar";
            this.Text = "Modificar";
            ((System.ComponentModel.ISupportInitialize)(this.historial)).EndInit();
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
        private System.Windows.Forms.DataGridView historial;
        private System.Windows.Forms.Button btnhistorial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox filtrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labNoel10;
    }
}