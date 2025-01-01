namespace Paqueteria.UI
{
    partial class frmInicioSesion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnIniciarSesion = new Button();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pbVercontrasena = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbVercontrasena).BeginInit();
            SuspendLayout();
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Font = new Font("Tahoma", 13.8F);
            btnIniciarSesion.Image = Properties.Resources.paneles;
            btnIniciarSesion.Location = new Point(555, 553);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(278, 37);
            btnIniciarSesion.TabIndex = 0;
            btnIniciarSesion.Text = "INICIAR SESIÓN";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += button1_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.ButtonHighlight;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.CausesValidation = false;
            txtUsuario.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.Gray;
            txtUsuario.Location = new Point(467, 404);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(437, 28);
            txtUsuario.TabIndex = 1;
            txtUsuario.Text = "USUARIO";
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtContraseña
            // 
            txtContraseña.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtContraseña.BackColor = SystemColors.ButtonHighlight;
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.CausesValidation = false;
            txtContraseña.Font = new Font("Tahoma", 13.8F);
            txtContraseña.ForeColor = Color.Gray;
            txtContraseña.Location = new Point(467, 486);
            txtContraseña.MaxLength = 20;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(434, 28);
            txtContraseña.TabIndex = 2;
            txtContraseña.Text = "CONTRASEÑA";
            txtContraseña.TextAlign = HorizontalAlignment.Center;
            txtContraseña.Enter += txtContraseña_Enter;
            txtContraseña.Leave += txtContraseña_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(355, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(645, 296);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(197, 754);
            panel3.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.camion;
            pictureBox2.Location = new Point(12, 163);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(159, 141);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.LogoEmpresa;
            pictureBox3.Location = new Point(203, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(63, 61);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 45;
            pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SteelBlue;
            panel4.Controls.Add(pictureBox4);
            panel4.Location = new Point(1176, -3);
            panel4.Name = "panel4";
            panel4.Size = new Size(246, 800);
            panel4.TabIndex = 46;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.logo2;
            pictureBox4.Location = new Point(48, 379);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(160, 207);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(462, 436);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(437, 1);
            panel1.TabIndex = 47;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(464, 523);
            panel2.Margin = new Padding(1);
            panel2.Name = "panel2";
            panel2.Size = new Size(437, 1);
            panel2.TabIndex = 48;
            // 
            // pbVercontrasena
            // 
            pbVercontrasena.Image = Properties.Resources.logo2;
            pbVercontrasena.Location = new Point(862, 480);
            pbVercontrasena.Name = "pbVercontrasena";
            pbVercontrasena.Size = new Size(42, 44);
            pbVercontrasena.SizeMode = PictureBoxSizeMode.StretchImage;
            pbVercontrasena.TabIndex = 49;
            pbVercontrasena.TabStop = false;
            pbVercontrasena.Click += pictureBox5_Click;
            // 
            // frmInicioSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1422, 754);
            Controls.Add(pbVercontrasena);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(pictureBox3);
            Controls.Add(panel3);
            Controls.Add(pictureBox1);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(btnIniciarSesion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmInicioSesion";
            Opacity = 0.96D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frmInicioSesion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbVercontrasena).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciarSesion;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private PictureBox pictureBox1;
        private Panel panel3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel4;
        private PictureBox pictureBox4;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pbVercontrasena;
    }
}
