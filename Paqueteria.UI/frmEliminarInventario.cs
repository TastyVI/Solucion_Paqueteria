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
    public partial class frmEliminarInventario : Form
    {
        public frmEliminarInventario()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(1440, 800);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void txtBuscarPaquete_Enter(object sender, EventArgs e)
        {
            if (txtBuscarPaquete.Text == "BUSCAR ID PAQUETE")
            {
                txtBuscarPaquete.Text = "";
                txtBuscarPaquete.ForeColor = Color.Black;
            }
        }

        private void txtBuscarPaquete_Leave(object sender, EventArgs e)
        {
            if (txtBuscarPaquete.Text == "")
            {
                txtBuscarPaquete.Text = "BUSCAR ID PAQUETE";
                txtBuscarPaquete.ForeColor = Color.Gray;
            }
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Close();
        }
    }
}
