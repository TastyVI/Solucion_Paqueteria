namespace Paqueteria.UI
{
    partial class frmAgregarDriver
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
            pictureBox2 = new PictureBox();
            btnAgregar = new Button();
            panel4 = new Panel();
            btnVolverMenu = new Button();
            pictureBox3 = new PictureBox();
            txtTipoDeUnidad = new TextBox();
            txtUsuario = new TextBox();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            txtNombreCompleto = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.LogoEmpresa;
            pictureBox2.Location = new Point(603, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(122, 131);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 39;
            pictureBox2.TabStop = false;
            // 
            // btnAgregar
            // 
            btnAgregar.Image = Properties.Resources.paneles;
            btnAgregar.ImageAlign = ContentAlignment.TopCenter;
            btnAgregar.Location = new Point(355, 342);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(122, 56);
            btnAgregar.TabIndex = 38;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SteelBlue;
            panel4.Controls.Add(btnVolverMenu);
            panel4.Controls.Add(pictureBox3);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(152, 450);
            panel4.TabIndex = 37;
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
            btnVolverMenu.Size = new Size(152, 43);
            btnVolverMenu.TabIndex = 10;
            btnVolverMenu.Text = "Volver al Menu";
            btnVolverMenu.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.AgregarConductor;
            pictureBox3.Location = new Point(12, 170);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 119);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // txtTipoDeUnidad
            // 
            txtTipoDeUnidad.BackColor = SystemColors.ButtonHighlight;
            txtTipoDeUnidad.BorderStyle = BorderStyle.None;
            txtTipoDeUnidad.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTipoDeUnidad.ForeColor = Color.Gray;
            txtTipoDeUnidad.Location = new Point(264, 268);
            txtTipoDeUnidad.Name = "txtTipoDeUnidad";
            txtTipoDeUnidad.Size = new Size(260, 28);
            txtTipoDeUnidad.TabIndex = 36;
            txtTipoDeUnidad.Text = "TIPO DE UNIDAD";
            txtTipoDeUnidad.Enter += txtTipoDeUnidad_Enter;
            txtTipoDeUnidad.Leave += txtTipoDeUnidad_Leave;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.ButtonHighlight;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.Gray;
            txtUsuario.Location = new Point(264, 216);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(260, 28);
            txtUsuario.TabIndex = 35;
            txtUsuario.Text = "USUARIO";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(264, 300);
            panel3.Margin = new Padding(1);
            panel3.Name = "panel3";
            panel3.Size = new Size(260, 1);
            panel3.TabIndex = 34;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(264, 248);
            panel2.Margin = new Padding(1);
            panel2.Name = "panel2";
            panel2.Size = new Size(260, 1);
            panel2.TabIndex = 33;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(264, 202);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 1);
            panel1.TabIndex = 32;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.BackColor = SystemColors.ButtonHighlight;
            txtNombreCompleto.BorderStyle = BorderStyle.None;
            txtNombreCompleto.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreCompleto.ForeColor = Color.Gray;
            txtNombreCompleto.Location = new Point(264, 170);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(260, 28);
            txtNombreCompleto.TabIndex = 31;
            txtNombreCompleto.Text = "NOMBRE COMPLETO";
            txtNombreCompleto.Enter += txtNombreCompleto_Enter;
            txtNombreCompleto.Leave += txtNombreCompleto_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(255, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(269, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // frmAgregarDriver
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(btnAgregar);
            Controls.Add(panel4);
            Controls.Add(txtTipoDeUnidad);
            Controls.Add(txtUsuario);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtNombreCompleto);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "frmAgregarDriver";
            Text = "frmAgregarDriver";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Button btnAgregar;
        private Panel panel4;
        private Button btnVolverMenu;
        private PictureBox pictureBox3;
        private TextBox txtTipoDeUnidad;
        private TextBox txtUsuario;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private TextBox txtNombreCompleto;
        private PictureBox pictureBox1;
    }
}