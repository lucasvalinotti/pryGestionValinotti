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
            fecha = dtpFecha.Value;
            tipo = cbTipoActividad.Text;
            detalle = txtDetalle.Text;
            reunion = optSi.Checked;
            Actividad actividad= new Actividad();
            actividad.Fecha = fecha;
            actividad.Tipo = tipo;
            actividad.Detalle = detalle;
            actividad.Reunion = reunion;
            for (int i = 0; i < checkboxes.Count; i++)
            {
                if (checkboxes[i].Checked == true)
                {
                    actividad.Tareas += checkboxes[i].Text + " ";
                }
            }
            try
            {
                actividades.Add(actividad);
                MessageBox.Show("Se agrego la actividad: " + actividad.Tipo + " del día: " + actividad.Fecha.ToString("dd/MM/yyyy"));
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo agregar la actividad, verifique los campos.");
            }
        }
    }
}
