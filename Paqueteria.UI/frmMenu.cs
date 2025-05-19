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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(1440, 800);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmAgregarPaquetes agregarPaquete = new frmAgregarPaquetes();
            agregarPaquete.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            frmPendientes pendiente = new frmPendientes();
            pendiente.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmAgregarUsuario agregar_usuario = new frmAgregarUsuario();
            agregar_usuario.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmInventarioLlegada inventario_llegada = new frmInventarioLlegada();
            inventario_llegada.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            frmAgregarDriver agregarDriver = new frmAgregarDriver();
            agregarDriver.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            frmRegistroPaqueteDevolucion devoluciones = new frmRegistroPaqueteDevolucion();
            devoluciones.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            frmEliminarInventario EliminarInventario = new frmEliminarInventario();
            EliminarInventario.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            frmRuta rutas = new frmRuta();
            rutas.Show();

        }

        private void label9_Click(object sender, EventArgs e)
        {
            frmInicioSesion frmInicioSesion = new frmInicioSesion();
            frmInicioSesion.Show();
        }
    }
}
