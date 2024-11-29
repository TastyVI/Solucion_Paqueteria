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
    public partial class frmRegistroPaqueteDevolucion : Form
    {
        public frmRegistroPaqueteDevolucion()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtMotivo_Enter(object sender, EventArgs e)
        {
            if (txtMotivo.Text == "MOTIVO")
            {
                txtMotivo.Text = "";
                txtMotivo.ForeColor = Color.Black;
            }
        }

        private void txtMotivo_Leave(object sender, EventArgs e)
        {
            if (txtMotivo.Text == "")
            {
                txtMotivo.Text = "MOTIVO";
                txtMotivo.ForeColor = Color.Gray;
            }
        }
    }
}
