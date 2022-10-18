namespace WindowsFormColaCircular
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
            this.txtdato = new System.Windows.Forms.TextBox();
            this.btninsertar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnvaciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colalista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtdato
            // 
            this.txtdato.Location = new System.Drawing.Point(77, 42);
            this.txtdato.Name = "txtdato";
            this.txtdato.Size = new System.Drawing.Size(159, 20);
            this.txtdato.TabIndex = 0;
            // 
            // btninsertar
            // 
            this.btninsertar.Location = new System.Drawing.Point(286, 39);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(129, 23);
            this.btninsertar.TabIndex = 1;
            this.btninsertar.Text = "INSERTAR";
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(286, 68);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(129, 23);
            this.btneliminar.TabIndex = 1;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnvaciar
            // 
            this.btnvaciar.Location = new System.Drawing.Point(286, 97);
            this.btnvaciar.Name = "btnvaciar";
            this.btnvaciar.Size = new System.Drawing.Size(129, 23);
            this.btnvaciar.TabIndex = 1;
            this.btnvaciar.Text = "VACIAR";
            this.btnvaciar.UseVisualStyleBackColor = true;
            this.btnvaciar.Click += new System.EventHandler(this.btnvaciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "COLA CIRCULAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dato";
            // 
            // colalista
            // 
            this.colalista.FormattingEnabled = true;
            this.colalista.Location = new System.Drawing.Point(77, 87);
            this.colalista.Name = "colalista";
            this.colalista.Size = new System.Drawing.Size(159, 186);
            this.colalista.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 292);
            this.Controls.Add(this.colalista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnvaciar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.txtdato);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdato;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnvaciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox colalista;
    }
}

