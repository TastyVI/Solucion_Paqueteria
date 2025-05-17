namespace Paqueteria.UI
{
    partial class frmAgregarUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            btnAgregar = new Button();
            button2 = new Button();
            txtNombreUsuario = new TextBox();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            txtNombreCompleto = new TextBox();
            panel4 = new Panel();
            txtContraseña = new TextBox();
            panel5 = new Panel();
            btnVolverMenu = new Button();
            pictureBox3 = new PictureBox();
            cbAdministrador = new CheckBox();
            pictureBox4 = new PictureBox();
            dataGridView1 = new DataGridView();
            panel6 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(316, -99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(663, 372);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            btnAgregar.Image = Properties.Resources.paneles;
            btnAgregar.ImageAlign = ContentAlignment.TopCenter;
            btnAgregar.Location = new Point(247, 615);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(159, 47);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            button2.Image = Properties.Resources.paneles;
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(453, 615);
            button2.Name = "button2";
            button2.Size = new Size(170, 47);
            button2.TabIndex = 8;
            button2.Text = "ELIMINAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.BackColor = SystemColors.ButtonHighlight;
            txtNombreUsuario.BorderStyle = BorderStyle.None;
            txtNombreUsuario.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txtNombreUsuario.ForeColor = Color.Gray;
            txtNombreUsuario.Location = new Point(253, 424);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(338, 40);
            txtNombreUsuario.TabIndex = 23;
            txtNombreUsuario.Text = "NOMBRE USUARIO";
            txtNombreUsuario.Enter += txtNombreUsuario_Enter;
            txtNombreUsuario.Leave += txtNombreUsuario_Leave;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            panel3.Location = new Point(253, 508);
            panel3.Margin = new Padding(1);
            panel3.Name = "panel3";
            panel3.Size = new Size(260, 1);
            panel3.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            panel2.Location = new Point(253, 456);
            panel2.Margin = new Padding(1);
            panel2.Name = "panel2";
            panel2.Size = new Size(260, 1);
            panel2.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            panel1.Location = new Point(253, 410);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 1);
            panel1.TabIndex = 20;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.BackColor = SystemColors.ButtonHighlight;
            txtNombreCompleto.BorderStyle = BorderStyle.None;
            txtNombreCompleto.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txtNombreCompleto.ForeColor = Color.Gray;
            txtNombreCompleto.Location = new Point(253, 363);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(338, 40);
            txtNombreCompleto.TabIndex = 19;
            txtNombreCompleto.Text = "NOMBRE COMPLETO";
            txtNombreCompleto.TextChanged += txtNombreCompleto_TextChanged;
            txtNombreCompleto.Enter += txtNombreCompleto_Enter;
            txtNombreCompleto.Leave += txtNombreCompleto_Leave;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            panel4.Location = new Point(248, 590);
            panel4.Margin = new Padding(1);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 1);
            panel4.TabIndex = 26;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = SystemColors.ButtonHighlight;
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txtContraseña.ForeColor = Color.Gray;
            txtContraseña.Location = new Point(248, 546);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(338, 40);
            txtContraseña.TabIndex = 25;
            txtContraseña.Text = "CONTRASEÑA";
            txtContraseña.Enter += txtContraseña_Enter;
            txtContraseña.Leave += txtContraseña_Leave;
            // 
            // panel5
            // 
            panel5.BackColor = Color.SteelBlue;
            panel5.Controls.Add(btnVolverMenu);
            panel5.Controls.Add(pictureBox3);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(205, 753);
            panel5.TabIndex = 27;
            // 
            // btnVolverMenu
            // 
            btnVolverMenu.Dock = DockStyle.Top;
            btnVolverMenu.FlatStyle = FlatStyle.Flat;
            btnVolverMenu.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolverMenu.ForeColor = Color.White;
            btnVolverMenu.Image = Properties.Resources.paneles;
            btnVolverMenu.ImageAlign = ContentAlignment.BottomRight;
            btnVolverMenu.Location = new Point(0, 0);
            btnVolverMenu.Name = "btnVolverMenu";
            btnVolverMenu.Size = new Size(205, 43);
            btnVolverMenu.TabIndex = 29;
            btnVolverMenu.Text = "Volver";
            btnVolverMenu.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.agregarU;
            pictureBox3.Location = new Point(0, 136);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(202, 255);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 28;
            pictureBox3.TabStop = false;
            // 
            // cbAdministrador
            // 
            cbAdministrador.AutoSize = true;
            cbAdministrador.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            cbAdministrador.ForeColor = Color.Gray;
            cbAdministrador.Location = new Point(245, 490);
            cbAdministrador.Name = "cbAdministrador";
            cbAdministrador.Size = new Size(338, 45);
            cbAdministrador.TabIndex = 28;
            cbAdministrador.Text = "ES ADMINISTRADOR";
            cbAdministrador.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.logo22;
            pictureBox4.Location = new Point(1222, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(188, 158);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 45;
            pictureBox4.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(985, 176);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(373, 519);
            dataGridView1.TabIndex = 46;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaptionText;
            panel6.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            panel6.Location = new Point(247, 468);
            panel6.Margin = new Padding(1);
            panel6.Name = "panel6";
            panel6.Size = new Size(300, 1);
            panel6.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(211, 289);
            label1.Name = "label1";
            label1.Size = new Size(518, 54);
            label1.TabIndex = 47;
            label1.Text = "Agregar un nuevo Usuario";
            // 
            // frmAgregarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1422, 753);
            Controls.Add(label1);
            Controls.Add(panel6);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox4);
            Controls.Add(cbAdministrador);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombreUsuario);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtNombreCompleto);
            Controls.Add(button2);
            Controls.Add(btnAgregar);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "frmAgregarUsuario";
            Text = "frmAgregarUsuario";
            Load += frmAgregarUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnAgregar;
        private Button button2;
        private TextBox txtNombreUsuario;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private TextBox txtNombreCompleto;
        private Panel panel4;
        private TextBox txtContraseña;
        private Panel panel5;
        private PictureBox pictureBox3;
        private CheckBox cbAdministrador;
        private Button btnVolverMenu;
        private PictureBox pictureBox4;
        private DataGridView dataGridView1;
        private Panel panel6;
        private Label label1;
    }
}