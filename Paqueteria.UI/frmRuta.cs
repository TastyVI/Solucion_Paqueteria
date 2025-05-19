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
    public partial class frmRuta : Form
    {
        public frmRuta()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(1558, 800);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void txtCantidad_Enter(object sender, EventArgs e)
        {
            if (txtID_ruta.Text == "ID")
            {
                txtID_ruta.Text = "";
                txtID_ruta.ForeColor = Color.Black;
            }
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            if (txtID_ruta.Text == "")
            {
                txtID_ruta.Text = "ID";
                txtID_ruta.ForeColor = Color.Gray;
            }
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.ShowDialog();
        }
    }
}
