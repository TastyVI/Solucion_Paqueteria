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

        private void txtContrase�a_Enter(object sender, EventArgs e)
        {
            if (txtContrase�a.Text == "CONTRASE�A")
            {
                txtContrase�a.Text = "";
                txtContrase�a.ForeColor = Color.Black;
                txtContrase�a.UseSystemPasswordChar = true;
            }
        }

        private void txtContrase�a_Leave(object sender, EventArgs e)
        {
            if (txtContrase�a.Text == "")
            {
                txtContrase�a.Text = "CONTRASE�A";
                txtContrase�a.ForeColor = Color.Gray;
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


            if (txtContrase�a.UseSystemPasswordChar==true)
            {
                pbVercontrasena.Image = Properties.Resources.ojo_abiert;
                txtContrase�a.UseSystemPasswordChar = false;
                aux = false;

            }
            else            
            {
                pbVercontrasena.Image = Properties.Resources.ojo_cerrado;
                txtContrase�a.UseSystemPasswordChar = true;
                aux = true;
            }
            
        }
        
    }

}
