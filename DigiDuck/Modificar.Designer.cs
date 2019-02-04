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
            this.SuspendLayout();
            // 
            // btnkill
            // 
            this.btnkill.Location = new System.Drawing.Point(31, 279);
            this.btnkill.Name = "btnkill";
            this.btnkill.Size = new System.Drawing.Size(104, 23);
            this.btnkill.TabIndex = 0;
            this.btnkill.Text = "Matar al Pato";
            this.btnkill.UseVisualStyleBackColor = true;
            this.btnkill.Click += new System.EventHandler(this.btnkill_Click);
            // 
            // pato
            // 
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
            this.lblnombre.Location = new System.Drawing.Point(28, 87);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(35, 13);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "label1";
            // 
            // lblquack
            // 
            this.lblquack.AutoSize = true;
            this.lblquack.Location = new System.Drawing.Point(28, 118);
            this.lblquack.Name = "lblquack";
            this.lblquack.Size = new System.Drawing.Size(35, 13);
            this.lblquack.TabIndex = 3;
            this.lblquack.Text = "label2";
            // 
            // lblnada
            // 
            this.lblnada.AutoSize = true;
            this.lblnada.Location = new System.Drawing.Point(28, 150);
            this.lblnada.Name = "lblnada";
            this.lblnada.Size = new System.Drawing.Size(35, 13);
            this.lblnada.TabIndex = 4;
            this.lblnada.Text = "label3";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(28, 184);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(35, 13);
            this.lblfecha.TabIndex = 5;
            this.lblfecha.Text = "label4";
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lblnada);
            this.Controls.Add(this.lblquack);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.pato);
            this.Controls.Add(this.btnkill);
            this.Name = "Modificar";
            this.Text = "Modificar";
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
    }
}