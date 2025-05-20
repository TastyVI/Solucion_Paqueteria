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
            this.ClientSize = new System.Drawing.Size(1440, 800);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        

        private void txtMotivo_Enter(object sender, EventArgs e)
        {
            if (txtMotivo.Text == "ID PAQUETE")
            {
                txtMotivo.Text = "";
                txtMotivo.ForeColor = Color.Black;
            }
        }

        private void txtMotivo_Leave(object sender, EventArgs e)
        {
            if (txtMotivo.Text == "")
            {
                txtMotivo.Text = "ID PAQUETE";
                txtMotivo.ForeColor = Color.Gray;
            }
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
            this.Close();
        }
    }
}
