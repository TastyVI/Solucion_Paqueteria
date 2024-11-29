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
            pictureBox2 = new PictureBox();
            btnAgregar = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(216, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(265, 148);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(593, 46);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 62);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // btnAgregar
            // 
            btnAgregar.Image = Properties.Resources.paneles;
            btnAgregar.ImageAlign = ContentAlignment.TopCenter;
            btnAgregar.Location = new Point(210, 380);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(130, 29);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.paneles;
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(346, 380);
            button2.Name = "button2";
            button2.Size = new Size(130, 29);
            button2.TabIndex = 8;
            button2.Text = "ELIMINAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(520, 150);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(241, 264);
            listBox1.TabIndex = 9;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.BackColor = SystemColors.ButtonHighlight;
            txtNombreUsuario.BorderStyle = BorderStyle.None;
            txtNombreUsuario.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreUsuario.ForeColor = Color.Gray;
            txtNombreUsuario.Location = new Point(216, 212);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(260, 28);
            txtNombreUsuario.TabIndex = 23;
            txtNombreUsuario.Text = "NOMBRE USUARIO";
            txtNombreUsuario.Enter += txtNombreUsuario_Enter;
            txtNombreUsuario.Leave += txtNombreUsuario_Leave;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(216, 296);
            panel3.Margin = new Padding(1);
            panel3.Name = "panel3";
            panel3.Size = new Size(260, 1);
            panel3.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(216, 244);
            panel2.Margin = new Padding(1);
            panel2.Name = "panel2";
            panel2.Size = new Size(260, 1);
            panel2.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(216, 198);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 1);
            panel1.TabIndex = 20;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.BackColor = SystemColors.ButtonHighlight;
            txtNombreCompleto.BorderStyle = BorderStyle.None;
            txtNombreCompleto.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreCompleto.ForeColor = Color.Gray;
            txtNombreCompleto.Location = new Point(216, 166);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(260, 28);
            txtNombreCompleto.TabIndex = 19;
            txtNombreCompleto.Text = "NOMBRE COMPLETO";
            txtNombreCompleto.Enter += txtNombreCompleto_Enter;
            txtNombreCompleto.Leave += txtNombreCompleto_Leave;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(216, 346);
            panel4.Margin = new Padding(1);
            panel4.Name = "panel4";
            panel4.Size = new Size(260, 1);
            panel4.TabIndex = 26;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = SystemColors.ButtonHighlight;
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.ForeColor = Color.Gray;
            txtContraseña.Location = new Point(216, 314);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(260, 28);
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
            panel5.Size = new Size(163, 450);
            panel5.TabIndex = 27;
            // 
            // btnVolverMenu
            // 
            btnVolverMenu.Dock = DockStyle.Top;
            btnVolverMenu.FlatStyle = FlatStyle.Flat;
            btnVolverMenu.ForeColor = Color.White;
            btnVolverMenu.Image = Properties.Resources.paneles;
            btnVolverMenu.ImageAlign = ContentAlignment.BottomRight;
            btnVolverMenu.Location = new Point(0, 0);
            btnVolverMenu.Name = "btnVolverMenu";
            btnVolverMenu.Size = new Size(163, 43);
            btnVolverMenu.TabIndex = 29;
            btnVolverMenu.Text = "Volver al Menu";
            btnVolverMenu.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.agregarU;
            pictureBox3.Location = new Point(0, 136);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(163, 174);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 28;
            pictureBox3.TabStop = false;
            // 
            // cbAdministrador
            // 
            cbAdministrador.AutoSize = true;
            cbAdministrador.Font = new Font("Tahoma", 13.8F);
            cbAdministrador.ForeColor = Color.Gray;
            cbAdministrador.Location = new Point(216, 260);
            cbAdministrador.Name = "cbAdministrador";
            cbAdministrador.Size = new Size(248, 32);
            cbAdministrador.TabIndex = 28;
            cbAdministrador.Text = "ES ADMINISTRADOR";
            cbAdministrador.UseVisualStyleBackColor = true;
            // 
            // frmAgregarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(cbAdministrador);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombreUsuario);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtNombreCompleto);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(btnAgregar);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "frmAgregarUsuario";
            Text = "frmAgregarUsuario";
            Load += frmAgregarUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnAgregar;
        private Button button2;
        private ListBox listBox1;
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
    }
}