using System.Globalization;
using System.Runtime.Intrinsics.X86;

namespace Paqueteria.UI
{
    public partial class frmInicioSesion : Form
    {


        public frmInicioSesion()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(1440, 800);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
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

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.Gray;
                pbVercontrasena.Image = Properties.Resources.ojo_cerrado;
                aux= false;
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
        Boolean aux = true;

        private void pictureBox5_Click(object sender, EventArgs e)
        {


            if (txtContraseña.UseSystemPasswordChar==true)
            {
                pbVercontrasena.Image = Properties.Resources.ojo_abiert;
                txtContraseña.UseSystemPasswordChar = false;
                aux = false;

            }
            else            
            {
                pbVercontrasena.Image = Properties.Resources.ojo_cerrado;
                txtContraseña.UseSystemPasswordChar = true;
                aux = true;
            }
            
        }
        
    }

}
