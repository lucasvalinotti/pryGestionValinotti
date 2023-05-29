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
    public partial class frmMostrar : Form
    {
        List<Actividad> actividades;
        public frmMostrar()
        {
            InitializeComponent();
        }
        public frmMostrar(List<Actividad> actividadesOrigen)
        {
            InitializeComponent();
            actividades = actividadesOrigen;   
        }

        private void frmMostrar_Load(object sender, EventArgs e)
        {
            cbActividad.DataSource = actividades;
            cbActividad.ValueMember = "Tipo";
            mostrarDetalles();
        }

        private void cbActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarDetalles();
        }

        private void mostrarDetalles()
        {
            lbMostrarActividades.Items.Clear();
            Actividad actividad = (Actividad)cbActividad.SelectedItem;
            if (actividad != null)
            {
                string reunion;
                if (actividad.Reunion == true)
                {
                    reunion = "Si";
                }
                else
                {
                    reunion = "No";
                }
                lbMostrarActividades.Items.Add("Fecha: " + actividad.Fecha.ToString("dd/MM/yyyy"));
                lbMostrarActividades.Items.Add("Tipo: " + actividad.Tipo);
                lbMostrarActividades.Items.Add("Detalle: " + actividad.Detalle);
                lbMostrarActividades.Items.Add("Reunion: " + reunion);
                lbMostrarActividades.Items.Add("Tareas: " + actividad.Tareas);
            }
            else
            {
                lbMostrarActividades.Items.Clear();
                lbMostrarActividades.Items.Add("No se encontraron actividades...");
            }
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
