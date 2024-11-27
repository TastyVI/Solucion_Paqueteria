using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paqueteria.UI
{
    public partial class frmAgregarUsuario : Form
    {
        public frmAgregarUsuario()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreCompleto_Enter(object sender, EventArgs e)
        {
            if (txtNombreCompleto.Text == "NOMBRE COMPLETO")
            {
                txtNombreCompleto.Text = "";
                txtNombreCompleto.ForeColor = Color.Black;
            }
        }

        private void txtNombreCompleto_Leave(object sender, EventArgs e)
        {
            if (txtNombreCompleto.Text == "")
            {
                txtNombreCompleto.Text = "NOMBRE COMPLETO";
                txtNombreCompleto.ForeColor = Color.Gray;
            }
        }

        private void txtNombreUsuario_Enter(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text == "NOMBRE USUARIO")
            {
                txtNombreUsuario.Text = "";
                txtNombreUsuario.ForeColor = Color.Black;
            }
        }

        private void txtNombreUsuario_Leave(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text == "")
            {
                txtNombreUsuario.Text = "NOMBRE USUARIO";
                txtNombreUsuario.ForeColor = Color.Gray;
            }
        }

        private void txtTipoUsuario_Enter(object sender, EventArgs e)
        {
            if (txtTipoUsuario.Text == "TIPO USUARIO")
            {
                txtTipoUsuario.Text = "";
                txtTipoUsuario.ForeColor = Color.Black;
            }
        }

        private void txtTipoUsuario_Leave(object sender, EventArgs e)
        {
            if (txtTipoUsuario.Text == "")
            {
                txtTipoUsuario.Text = "TIPO USUARIO";
                txtTipoUsuario.ForeColor = Color.Gray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
               
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.Gray;
               
            }
        }
    }
}
