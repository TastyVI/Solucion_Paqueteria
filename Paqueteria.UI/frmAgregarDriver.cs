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
    public partial class frmAgregarDriver : Form
    {
        public frmAgregarDriver()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(1440, 800);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;



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

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.Gray;
            }
        }

        private void txtTipoDeUnidad_Enter(object sender, EventArgs e)
        {
            if (txtTipoDeUnidad.Text == "TIPO DE UNIDAD")
            {
                txtTipoDeUnidad.Text = "";
                txtTipoDeUnidad.ForeColor = Color.Black;
            }
        }

        private void txtTipoDeUnidad_Leave(object sender, EventArgs e)
        {
            if (txtTipoDeUnidad.Text == "")
            {
                txtTipoDeUnidad.Text = "TIPO DE UNIDAD";
                txtTipoDeUnidad.ForeColor = Color.Gray;
            }
        }

        private void frmAgregarDriver_Load(object sender, EventArgs e)
        {

        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Close();
        }
    }
}
