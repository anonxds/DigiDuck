namespace DigiDuck
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnadd = new System.Windows.Forms.Button();
            this.cmdmod = new System.Windows.Forms.Button();
            this.btnterminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(86, 75);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(112, 59);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Agregar Patos";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // cmdmod
            // 
            this.cmdmod.Location = new System.Drawing.Point(230, 75);
            this.cmdmod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdmod.Name = "cmdmod";
            this.cmdmod.Size = new System.Drawing.Size(112, 59);
            this.cmdmod.TabIndex = 1;
            this.cmdmod.Text = "Ver Patos";
            this.cmdmod.UseVisualStyleBackColor = true;
            this.cmdmod.Click += new System.EventHandler(this.cmdmod_Click);
            // 
            // btnterminar
            // 
            this.btnterminar.Location = new System.Drawing.Point(177, 163);
            this.btnterminar.Name = "btnterminar";
            this.btnterminar.Size = new System.Drawing.Size(75, 38);
            this.btnterminar.TabIndex = 2;
            this.btnterminar.Text = "Salir";
            this.btnterminar.UseVisualStyleBackColor = true;
            this.btnterminar.Click += new System.EventHandler(this.btnterminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(435, 234);
            this.Controls.Add(this.btnterminar);
            this.Controls.Add(this.cmdmod);
            this.Controls.Add(this.btnadd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button cmdmod;
        private System.Windows.Forms.Button btnterminar;
    }
}

