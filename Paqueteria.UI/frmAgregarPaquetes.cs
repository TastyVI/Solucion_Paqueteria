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
    public partial class frmAgregarPaquetes : Form
    {
        public frmAgregarPaquetes()
        {
            InitializeComponent();
        }

        private void txtId_Enter(object sender, EventArgs e)
        {
            if (txtId.Text == "ID")
            {
                txtId.Text = "";
                txtId.ForeColor = Color.Black;
            }
        }

        private void txtId_Leave(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                txtId.Text = "ID";
                txtId.ForeColor = Color.Gray;
            }
        }

        private void txtFecha_Enter(object sender, EventArgs e)
        {
            if (txtFecha.Text == "FECHA")
            {
                txtFecha.Text = "";
                txtFecha.ForeColor = Color.Black;
            }
        }

        private void txtFecha_Leave(object sender, EventArgs e)
        {
            if (txtFecha.Text == "")
            {
                txtFecha.Text = "FECHA";
                txtFecha.ForeColor = Color.Gray;
            }
        }

        private void txtUbicacion_Enter(object sender, EventArgs e)
        {
            if (txtUbicacion.Text == "UBICACIÓN")
            {
                txtUbicacion.Text = "";
                txtUbicacion.ForeColor = Color.Black;
            }
        }

        private void txtUbicacion_Leave(object sender, EventArgs e)
        {
            if (txtUbicacion.Text == "")
            {
                txtUbicacion.Text = "UBICACIÓN";
                txtUbicacion.ForeColor = Color.Gray;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
