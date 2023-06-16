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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void cmdIngresar_Click(object sender, EventArgs e)
        {
            string user = cbUsuario.Text;
            string password = txtContrasena.Text;
            switch (user)
            {
                case "Corcho Dios":
                    if (password == "corcho123" )
                    {
                        frmPrincipal frmPrincipal = new frmPrincipal(user);
                        this.Hide();
                        frmPrincipal.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta!");
                    }
                    break;
                case "Sancor Sampaoli":
                    if (password == "sancor123")
                    {
                        frmPrincipal frmPrincipal = new frmPrincipal(user);
                        this.Hide();
                        frmPrincipal.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta!");
                    }
                    break;
                case "Lucas Lucon":
                    if (password == "lucas123")
                    {
                        frmPrincipal frmPrincipal = new frmPrincipal(user);
                        this.Hide();
                        frmPrincipal.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta!");
                    }
                    break;
                case "Charango":
                    if (password == "charango123")
                    {
                        frmPrincipal frmPrincipal = new frmPrincipal(user);
                        this.Hide();
                        frmPrincipal.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta!");
                    }
                    break;
                case "Archivo Ejecutable":
                    if (password == ".exe")
                    {
                        frmPrincipal frmPrincipal = new frmPrincipal(user);
                        this.Hide();
                        frmPrincipal.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta!");
                    }
                    break;
                case "Wana Wanabi":
                    if (password == "marielasosa")
                    {
                        frmPrincipal frmPrincipal = new frmPrincipal(user);
                        this.Hide();
                        frmPrincipal.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta!");
                    }
                    break;
                default:
                    MessageBox.Show("Usuario incorrecto");
                    break;
            }
        }

        private void cbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtContrasena.Focus();
        }
    }
}
