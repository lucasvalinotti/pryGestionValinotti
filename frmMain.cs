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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
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
    }
}
