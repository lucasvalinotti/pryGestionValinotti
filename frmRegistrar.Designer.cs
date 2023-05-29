namespace pryGestion
{
    partial class frmRegistrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrar));
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.lblTipoActividad = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTipoActividad = new System.Windows.Forms.ComboBox();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.gbReunion = new System.Windows.Forms.GroupBox();
            this.optNo = new System.Windows.Forms.RadioButton();
            this.optSi = new System.Windows.Forms.RadioButton();
            this.gbTareas = new System.Windows.Forms.GroupBox();
            this.chkDebate = new System.Windows.Forms.CheckBox();
            this.chkNotas = new System.Windows.Forms.CheckBox();
            this.chkInvestigacion = new System.Windows.Forms.CheckBox();
            this.chkRepositorio = new System.Windows.Forms.CheckBox();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdRegistrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdVer = new System.Windows.Forms.Button();
            this.gbReunion.SuspendLayout();
            this.gbTareas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(16, 16);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(138, 84);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(121, 49);
            this.txtDetalle.TabIndex = 1;
            // 
            // lblTipoActividad
            // 
            this.lblTipoActividad.AutoSize = true;
            this.lblTipoActividad.Location = new System.Drawing.Point(16, 52);
            this.lblTipoActividad.Name = "lblTipoActividad";
            this.lblTipoActividad.Size = new System.Drawing.Size(75, 13);
            this.lblTipoActividad.TabIndex = 2;
            this.lblTipoActividad.Text = "Tipo Actividad";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(59, 12);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(423, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Relevamient, propuesta, diagnostico, analisis, diagrama de base de datos, program" +
    "acion";
            // 
            // cbTipoActividad
            // 
            this.cbTipoActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoActividad.FormattingEnabled = true;
            this.cbTipoActividad.Items.AddRange(new object[] {
            "Relevamiento",
            "Propuesta",
            "Diagnostico",
            "Analisis",
            "Diagrama BD",
            "Programacion"});
            this.cbTipoActividad.Location = new System.Drawing.Point(138, 49);
            this.cbTipoActividad.Name = "cbTipoActividad";
            this.cbTipoActividad.Size = new System.Drawing.Size(121, 21);
            this.cbTipoActividad.TabIndex = 5;
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Location = new System.Drawing.Point(16, 84);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(86, 13);
            this.lblDetalle.TabIndex = 6;
            this.lblDetalle.Text = "Detalle actividad";
            // 
            // gbReunion
            // 
            this.gbReunion.Controls.Add(this.optNo);
            this.gbReunion.Controls.Add(this.optSi);
            this.gbReunion.Location = new System.Drawing.Point(18, 139);
            this.gbReunion.Name = "gbReunion";
            this.gbReunion.Size = new System.Drawing.Size(200, 100);
            this.gbReunion.TabIndex = 7;
            this.gbReunion.TabStop = false;
            this.gbReunion.Text = "Reunion";
            // 
            // optNo
            // 
            this.optNo.AutoSize = true;
            this.optNo.Checked = true;
            this.optNo.Location = new System.Drawing.Point(41, 62);
            this.optNo.Name = "optNo";
            this.optNo.Size = new System.Drawing.Size(39, 17);
            this.optNo.TabIndex = 1;
            this.optNo.TabStop = true;
            this.optNo.Text = "No";
            this.optNo.UseVisualStyleBackColor = true;
            // 
            // optSi
            // 
            this.optSi.AutoSize = true;
            this.optSi.Location = new System.Drawing.Point(41, 29);
            this.optSi.Name = "optSi";
            this.optSi.Size = new System.Drawing.Size(34, 17);
            this.optSi.TabIndex = 0;
            this.optSi.Text = "Si";
            this.optSi.UseVisualStyleBackColor = true;
            // 
            // gbTareas
            // 
            this.gbTareas.Controls.Add(this.chkDebate);
            this.gbTareas.Controls.Add(this.chkNotas);
            this.gbTareas.Controls.Add(this.chkInvestigacion);
            this.gbTareas.Controls.Add(this.chkRepositorio);
            this.gbTareas.Location = new System.Drawing.Point(18, 246);
            this.gbTareas.Name = "gbTareas";
            this.gbTareas.Size = new System.Drawing.Size(241, 100);
            this.gbTareas.TabIndex = 8;
            this.gbTareas.TabStop = false;
            this.gbTareas.Text = "Tareas";
            // 
            // chkDebate
            // 
            this.chkDebate.AutoSize = true;
            this.chkDebate.Location = new System.Drawing.Point(131, 56);
            this.chkDebate.Name = "chkDebate";
            this.chkDebate.Size = new System.Drawing.Size(61, 17);
            this.chkDebate.TabIndex = 3;
            this.chkDebate.Text = "Debate";
            this.chkDebate.UseVisualStyleBackColor = true;
            // 
            // chkNotas
            // 
            this.chkNotas.AutoSize = true;
            this.chkNotas.Location = new System.Drawing.Point(31, 56);
            this.chkNotas.Name = "chkNotas";
            this.chkNotas.Size = new System.Drawing.Size(92, 17);
            this.chkNotas.TabIndex = 2;
            this.chkNotas.Text = "Notas reuniòn";
            this.chkNotas.UseVisualStyleBackColor = true;
            // 
            // chkInvestigacion
            // 
            this.chkInvestigacion.AutoSize = true;
            this.chkInvestigacion.Location = new System.Drawing.Point(131, 33);
            this.chkInvestigacion.Name = "chkInvestigacion";
            this.chkInvestigacion.Size = new System.Drawing.Size(89, 17);
            this.chkInvestigacion.TabIndex = 1;
            this.chkInvestigacion.Text = "Investigación";
            this.chkInvestigacion.UseVisualStyleBackColor = true;
            // 
            // chkRepositorio
            // 
            this.chkRepositorio.AutoSize = true;
            this.chkRepositorio.Location = new System.Drawing.Point(31, 33);
            this.chkRepositorio.Name = "chkRepositorio";
            this.chkRepositorio.Size = new System.Drawing.Size(79, 17);
            this.chkRepositorio.TabIndex = 0;
            this.chkRepositorio.Text = "Repositorio";
            this.chkRepositorio.UseVisualStyleBackColor = true;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(163, 352);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(75, 23);
            this.cmdCancelar.TabIndex = 9;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.Location = new System.Drawing.Point(49, 352);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(75, 23);
            this.cmdRegistrar.TabIndex = 10;
            this.cmdRegistrar.Text = "Registrar";
            this.cmdRegistrar.UseVisualStyleBackColor = true;
            this.cmdRegistrar.Click += new System.EventHandler(this.cmdRegistrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Grabar la seleccion en variables";
            // 
            // cmdVer
            // 
            this.cmdVer.Location = new System.Drawing.Point(97, 381);
            this.cmdVer.Name = "cmdVer";
            this.cmdVer.Size = new System.Drawing.Size(93, 23);
            this.cmdVer.TabIndex = 12;
            this.cmdVer.Text = "Ver Actividades";
            this.cmdVer.UseVisualStyleBackColor = true;
            this.cmdVer.Click += new System.EventHandler(this.cmdVer_Click);
            // 
            // frmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdVer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdRegistrar);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.gbTareas);
            this.Controls.Add(this.gbReunion);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.cbTipoActividad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblTipoActividad);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.lblFecha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Actividad";
            this.Load += new System.EventHandler(this.frmRegistrar_Load);
            this.gbReunion.ResumeLayout(false);
            this.gbReunion.PerformLayout();
            this.gbTareas.ResumeLayout(false);
            this.gbTareas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label lblTipoActividad;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTipoActividad;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.GroupBox gbReunion;
        private System.Windows.Forms.RadioButton optNo;
        private System.Windows.Forms.RadioButton optSi;
        private System.Windows.Forms.GroupBox gbTareas;
        private System.Windows.Forms.CheckBox chkDebate;
        private System.Windows.Forms.CheckBox chkNotas;
        private System.Windows.Forms.CheckBox chkInvestigacion;
        private System.Windows.Forms.CheckBox chkRepositorio;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdRegistrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdVer;
    }
}