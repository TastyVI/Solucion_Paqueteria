using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

using Microsoft.Win32;

namespace Paqueteria.UI
{
    public partial class frmAgregarUsuario : Form
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "tfk2wOtw3M5QO2yzxt1ZtchC9BJSbwgWIBxUEWUl",
            BasePath = "https://solucion-paqueteria-bc199-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        public frmAgregarUsuario()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(1440, 800);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            client = new FireSharp.FirebaseClient(config);

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

        private void frmAgregarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Guid g = Guid.NewGuid();
            string uuid = g.ToString();
            string usuario;
            if (!cbAdministrador.Checked)
            {
                usuario = "Auxiliar";
            }
            else
            {
                usuario = "Administrador";
            }
            var registrarse = new Registrarse
            {
                Usuario = txtNombreUsuario.Text,
                Contrasena = txtContraseña.Text,
                Nombre_Completo = txtNombreCompleto.Text,
                Tipo_Usuario = usuario,
                Id = uuid,
            };
            FirebaseResponse response = client.Set("Usuario/" + uuid, registrarse);
            MessageBox.Show("Usuario registrado existosamente");

        }

        private void txtNombreCompleto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
