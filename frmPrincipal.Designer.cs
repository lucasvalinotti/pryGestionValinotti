namespace pryGestion
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmdRegistrar = new System.Windows.Forms.PictureBox();
            this.lblRegistar = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.cmdVerActividades = new System.Windows.Forms.PictureBox();
            this.lblVer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cmdRegistrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVerActividades)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(232, 54);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(268, 41);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "CORRRCHO SA";
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("cmdRegistrar.Image")));
            this.cmdRegistrar.Location = new System.Drawing.Point(47, 179);
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
            this.lblRegistar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistar.Location = new System.Drawing.Point(21, 330);
            this.lblRegistar.Name = "lblRegistar";
            this.lblRegistar.Size = new System.Drawing.Size(233, 28);
            this.lblRegistar.TabIndex = 3;
            this.lblRegistar.Text = "Registrar Actividad";
            this.lblRegistar.Visible = false;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.Location = new System.Drawing.Point(287, 95);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(167, 21);
            this.lblSubtitulo.TabIndex = 4;
            this.lblSubtitulo.Text = "Venta de Vectorrres";
            // 
            // pbLogo
            // 
            this.pbLogo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(12, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(187, 148);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 5;
            this.pbLogo.TabStop = false;
            // 
            // cmdVerActividades
            // 
            this.cmdVerActividades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdVerActividades.Image = ((System.Drawing.Image)(resources.GetObject("cmdVerActividades.Image")));
            this.cmdVerActividades.Location = new System.Drawing.Point(313, 179);
            this.cmdVerActividades.Name = "cmdVerActividades";
            this.cmdVerActividades.Size = new System.Drawing.Size(187, 148);
            this.cmdVerActividades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cmdVerActividades.TabIndex = 6;
            this.cmdVerActividades.TabStop = false;
            this.cmdVerActividades.Click += new System.EventHandler(this.cmdVerActividades_Click);
            this.cmdVerActividades.MouseEnter += new System.EventHandler(this.cmdVerActividades_MouseEnter);
            this.cmdVerActividades.MouseLeave += new System.EventHandler(this.cmdVerActividades_MouseLeave);
            // 
            // lblVer
            // 
            this.lblVer.AutoSize = true;
            this.lblVer.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVer.Location = new System.Drawing.Point(308, 330);
            this.lblVer.Name = "lblVer";
            this.lblVer.Size = new System.Drawing.Size(198, 28);
            this.lblVer.TabIndex = 7;
            this.lblVer.Text = "Ver Actividades";
            this.lblVer.Visible = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(556, 397);
            this.Controls.Add(this.lblVer);
            this.Controls.Add(this.cmdVerActividades);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblRegistar);
            this.Controls.Add(this.cmdRegistrar);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de actividades - Desarrollo de Software";
            ((System.ComponentModel.ISupportInitialize)(this.cmdRegistrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVerActividades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox cmdRegistrar;
        private System.Windows.Forms.Label lblRegistar;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox cmdVerActividades;
        private System.Windows.Forms.Label lblVer;
    }
}

