namespace Paqueteria.UI
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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
                txtContrase�a.UseSystemPasswordChar = false;
            }
        }
    }

}
