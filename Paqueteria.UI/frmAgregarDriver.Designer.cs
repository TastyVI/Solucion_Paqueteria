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
            listBox1 = new ListBox();
            panel5 = new Panel();
            panel6 = new Panel();
            label2 = new Label();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo22;
            pictureBox2.Location = new Point(1213, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(206, 163);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 39;
            pictureBox2.TabStop = false;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Image = Properties.Resources.paneles;
            btnAgregar.ImageAlign = ContentAlignment.TopCenter;
            btnAgregar.Location = new Point(264, 560);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(159, 60);
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
            panel4.Size = new Size(179, 753);
            panel4.TabIndex = 37;
            // 
            // btnVolverMenu
            // 
            btnVolverMenu.Dock = DockStyle.Top;
            btnVolverMenu.FlatStyle = FlatStyle.Flat;
            btnVolverMenu.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolverMenu.ForeColor = Color.White;
            btnVolverMenu.Image = Properties.Resources.paneles;
            btnVolverMenu.ImageAlign = ContentAlignment.BottomRight;
            btnVolverMenu.Location = new Point(0, 0);
            btnVolverMenu.Name = "btnVolverMenu";
            btnVolverMenu.Size = new Size(179, 43);
            btnVolverMenu.TabIndex = 10;
            btnVolverMenu.Text = "Volver";
            btnVolverMenu.UseVisualStyleBackColor = true;
            btnVolverMenu.Click += btnVolverMenu_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.AgregarConductor;
            pictureBox3.Location = new Point(3, 168);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(164, 235);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // txtTipoDeUnidad
            // 
            txtTipoDeUnidad.BackColor = SystemColors.ButtonHighlight;
            txtTipoDeUnidad.BorderStyle = BorderStyle.None;
            txtTipoDeUnidad.Font = new Font("Microsoft Sans Serif", 18F);
            txtTipoDeUnidad.ForeColor = Color.Gray;
            txtTipoDeUnidad.Location = new Point(276, 479);
            txtTipoDeUnidad.MaxLength = 300;
            txtTipoDeUnidad.Name = "txtTipoDeUnidad";
            txtTipoDeUnidad.Size = new Size(315, 34);
            txtTipoDeUnidad.TabIndex = 36;
            txtTipoDeUnidad.Text = "TIPO DE UNIDAD";
            txtTipoDeUnidad.Enter += txtTipoDeUnidad_Enter;
            txtTipoDeUnidad.Leave += txtTipoDeUnidad_Leave;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.ButtonHighlight;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Microsoft Sans Serif", 18F);
            txtUsuario.ForeColor = Color.Gray;
            txtUsuario.Location = new Point(276, 406);
            txtUsuario.MaxLength = 300;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(315, 34);
            txtUsuario.TabIndex = 35;
            txtUsuario.Text = "USUARIO";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Font = new Font("Microsoft Sans Serif", 18F);
            panel3.Location = new Point(276, 511);
            panel3.Margin = new Padding(1);
            panel3.Name = "panel3";
            panel3.Size = new Size(315, 1);
            panel3.TabIndex = 34;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Font = new Font("Microsoft Sans Serif", 18F);
            panel2.Location = new Point(276, 438);
            panel2.Margin = new Padding(1);
            panel2.Name = "panel2";
            panel2.Size = new Size(315, 1);
            panel2.TabIndex = 33;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Font = new Font("Microsoft Sans Serif", 18F);
            panel1.Location = new Point(276, 376);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 1);
            panel1.TabIndex = 32;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.BackColor = SystemColors.ButtonHighlight;
            txtNombreCompleto.BorderStyle = BorderStyle.None;
            txtNombreCompleto.Font = new Font("Microsoft Sans Serif", 18F);
            txtNombreCompleto.ForeColor = Color.Gray;
            txtNombreCompleto.Location = new Point(276, 331);
            txtNombreCompleto.MaxLength = 300;
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(315, 34);
            txtNombreCompleto.TabIndex = 31;
            txtNombreCompleto.Text = "NOMBRE COMPLETO";
            txtNombreCompleto.Enter += txtNombreCompleto_Enter;
            txtNombreCompleto.Leave += txtNombreCompleto_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(185, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(630, 289);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(886, 181);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(508, 504);
            listBox1.TabIndex = 40;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaptionText;
            panel5.Font = new Font("Microsoft Sans Serif", 18F);
            panel5.Location = new Point(276, 442);
            panel5.Margin = new Padding(1);
            panel5.Name = "panel5";
            panel5.Size = new Size(315, 1);
            panel5.TabIndex = 33;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaptionText;
            panel6.Font = new Font("Microsoft Sans Serif", 18F);
            panel6.Location = new Point(276, 514);
            panel6.Margin = new Padding(1);
            panel6.Name = "panel6";
            panel6.Size = new Size(315, 1);
            panel6.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(995, 127);
            label2.Name = "label2";
            label2.Size = new Size(289, 41);
            label2.TabIndex = 42;
            label2.Text = "Usuarios Existentes";
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Image = Properties.Resources.paneles;
            btnEliminar.ImageAlign = ContentAlignment.TopCenter;
            btnEliminar.Location = new Point(458, 560);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(159, 60);
            btnEliminar.TabIndex = 43;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // frmAgregarDriver
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1422, 753);
            Controls.Add(btnEliminar);
            Controls.Add(label2);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(listBox1);
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
            Load += frmAgregarDriver_Load;
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
        private ListBox listBox1;
        private Panel panel5;
        private Panel panel6;
        private Label label2;
        private Button btnEliminar;
    }
}