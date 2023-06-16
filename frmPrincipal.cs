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
    public partial class frmPrincipal : Form
    {
        public string usuario { get; set; }
        public frmPrincipal(string nombre)
        {
            InitializeComponent();
            this.usuario = nombre;
        }

        private void cmdRegistrar_MouseLeave(object sender, EventArgs e)
        {
            lblRegistar.Visible = false;
        }

        private void cmdRegistrar_MouseEnter(object sender, EventArgs e)
        {
            lblRegistar.Visible = true;
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            frmRegistrar registrar = new frmRegistrar();
            this.Hide();
            registrar.ShowDialog();
            this.Show();
        }

        private void cmdVerActividades_MouseEnter(object sender, EventArgs e)
        {
            lblVer.Visible = true;
        }

        private void cmdVerActividades_MouseLeave(object sender, EventArgs e)
        {
            lblVer.Visible = false;
        }

        private void cmdVerActividades_Click(object sender, EventArgs e)
        {
            frmMostrar mostrar = new frmMostrar();
            this.Hide();
            mostrar.ShowDialog();
            this.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblSubtitulo.Text = "Bienvenido: " + this.usuario;
        }
    }
}
