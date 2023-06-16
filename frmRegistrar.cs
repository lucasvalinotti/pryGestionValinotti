using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestion
{
    public partial class frmRegistrar : Form
    {
        DateTime fecha;
        string tipo, detalle;
        bool reunion;
        List<Actividad> actividades = new List<Actividad>();
        List<CheckBox> checkboxes = new List<CheckBox>();
        public frmRegistrar()
        {
            InitializeComponent();
        }

        private void frmRegistrar_Load(object sender, EventArgs e)
        {
            checkboxes.Add(chkRepositorio);
            checkboxes.Add(chkInvestigacion);
            checkboxes.Add(chkNotas);
            checkboxes.Add(chkDebate);
        }

        private void cmdVer_Click(object sender, EventArgs e)
        {
            frmMostrar mostrar = new frmMostrar(actividades);
            this.Hide();
            mostrar.ShowDialog();
            this.Show();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            bool error = false;
            Actividad actividad= new Actividad();
            if (dtpFecha.Value >= DateTime.Today)
            {
                fecha = dtpFecha.Value;
                actividad.Fecha = fecha;
                error = false;
                if (cbTipoActividad.SelectedIndex != -1)
                {
                    tipo = cbTipoActividad.Text;
                    actividad.Tipo = tipo;
                    error = false;
                    if (txtDetalle.Text != "")
                    {
                        detalle = txtDetalle.Text;
                        actividad.Detalle = detalle;
                        error = false;
                    }
                    else 
                    {
                        MessageBox.Show("Error. Detalle erroneo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        error = true;
                    }
                }
                else 
                {
                    MessageBox.Show("Error. Seleccione una actividad.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error = true;
                }
            }
            else 
            {
                MessageBox.Show("Error. Seleccione la fecha de hoy o posterior.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            reunion = optSi.Checked;
            actividad.Reunion = reunion;
            for (int i = 0; i < checkboxes.Count; i++)
            {
                if (checkboxes[i].Checked == true)
                {
                    actividad.Tareas += checkboxes[i].Text;
                    if (i != (checkboxes.Count - 1)) actividad.Tareas += " - ";
                }
            }
            if (!error)
            {
                try
                {
                    actividades.Add(actividad);
                    MessageBox.Show("Se agrego la actividad: " + actividad.Tipo + " del día: " + actividad.Fecha.ToString("dd/MM/yyyy"));
                    resetearCampos();
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo agregar la actividad, verifique los campos.");
                }
            }
        }

        private void resetearCampos()
        {
            cbTipoActividad.Text = ""; txtDetalle.Text = "";
            for (int i = 0; i < checkboxes.Count; i++)
            {
                checkboxes[i].Checked = false;
            }
        }

    }
}
