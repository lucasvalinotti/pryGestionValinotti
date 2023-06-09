namespace pryGestion
{
    partial class frmMostrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMostrar));
            this.cbActividad = new System.Windows.Forms.ComboBox();
            this.lblActividad = new System.Windows.Forms.Label();
            this.lbMostrarActividades = new System.Windows.Forms.ListBox();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbActividad
            // 
            this.cbActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActividad.FormattingEnabled = true;
            this.cbActividad.Location = new System.Drawing.Point(198, 30);
            this.cbActividad.Name = "cbActividad";
            this.cbActividad.Size = new System.Drawing.Size(121, 21);
            this.cbActividad.TabIndex = 0;
            this.cbActividad.SelectedIndexChanged += new System.EventHandler(this.cbActividad_SelectedIndexChanged);
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Location = new System.Drawing.Point(106, 33);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(51, 13);
            this.lblActividad.TabIndex = 1;
            this.lblActividad.Text = "Actividad";
            // 
            // lbMostrarActividades
            // 
            this.lbMostrarActividades.FormattingEnabled = true;
            this.lbMostrarActividades.Location = new System.Drawing.Point(31, 73);
            this.lbMostrarActividades.Name = "lbMostrarActividades";
            this.lbMostrarActividades.Size = new System.Drawing.Size(325, 225);
            this.lbMostrarActividades.TabIndex = 2;
            // 
            // cmdVolver
            // 
            this.cmdVolver.Location = new System.Drawing.Point(155, 317);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(75, 23);
            this.cmdVolver.TabIndex = 3;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // frmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 373);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.lbMostrarActividades);
            this.Controls.Add(this.lblActividad);
            this.Controls.Add(this.cbActividad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMostrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostrar Actividades";
            this.Load += new System.EventHandler(this.frmMostrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbActividad;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.ListBox lbMostrarActividades;
        private System.Windows.Forms.Button cmdVolver;
    }
}