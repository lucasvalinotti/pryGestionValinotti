namespace pryGestion
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdRegistrar = new System.Windows.Forms.PictureBox();
            this.lblRegistar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cmdRegistrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Te piden hacer una app para registrar las actividades  (ejemplo: procesos de desa" +
    "rrollo)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "CORRRCHO SA";
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("cmdRegistrar.Image")));
            this.cmdRegistrar.Location = new System.Drawing.Point(164, 125);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(187, 148);
            this.cmdRegistrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cmdRegistrar.TabIndex = 2;
            this.cmdRegistrar.TabStop = false;
            this.cmdRegistrar.Click += new System.EventHandler(this.cmdRegistrar_Click);
            this.cmdRegistrar.MouseEnter += new System.EventHandler(this.cmdRegistrar_MouseEnter);
            this.cmdRegistrar.MouseLeave += new System.EventHandler(this.cmdRegistrar_MouseLeave);
            // 
            // lblRegistar
            // 
            this.lblRegistar.AutoSize = true;
            this.lblRegistar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistar.Location = new System.Drawing.Point(103, 289);
            this.lblRegistar.Name = "lblRegistar";
            this.lblRegistar.Size = new System.Drawing.Size(310, 39);
            this.lblRegistar.TabIndex = 3;
            this.lblRegistar.Text = "Registrar Actividad";
            this.lblRegistar.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Venta de Vectorrres";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 437);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRegistar);
            this.Controls.Add(this.cmdRegistrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de actividades - Desarrollo de Software";
            ((System.ComponentModel.ISupportInitialize)(this.cmdRegistrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox cmdRegistrar;
        private System.Windows.Forms.Label lblRegistar;
        private System.Windows.Forms.Label label3;
    }
}

