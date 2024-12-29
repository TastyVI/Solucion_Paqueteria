namespace Paqueteria.UI
{
    partial class frmRegistroPaqueteDevolucion
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
            lblListaPaquetes = new Label();
            btnGuardar = new Button();
            panel1 = new Panel();
            txtMotivo = new TextBox();
            panel2 = new Panel();
            btnVolverMenu = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            Ltbpendientes = new ListBox();
            cmbMotivo = new ComboBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblListaPaquetes
            // 
            lblListaPaquetes.AutoSize = true;
            lblListaPaquetes.Location = new Point(1062, 105);
            lblListaPaquetes.Name = "lblListaPaquetes";
            lblListaPaquetes.Size = new Size(228, 20);
            lblListaPaquetes.TabIndex = 13;
            lblListaPaquetes.Text = "Lista de paquetes de días anterio";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Image = Properties.Resources.paneles;
            btnGuardar.ImageAlign = ContentAlignment.TopCenter;
            btnGuardar.Location = new Point(429, 599);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(191, 50);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(247, 281);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(189, 1);
            panel1.TabIndex = 22;
            // 
            // txtMotivo
            // 
            txtMotivo.BackColor = SystemColors.ButtonHighlight;
            txtMotivo.BorderStyle = BorderStyle.None;
            txtMotivo.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMotivo.ForeColor = Color.Gray;
            txtMotivo.Location = new Point(247, 249);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(189, 28);
            txtMotivo.TabIndex = 21;
            txtMotivo.Text = "ID";
            txtMotivo.Enter += txtMotivo_Enter;
            txtMotivo.Leave += txtMotivo_Leave;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(btnVolverMenu);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(176, 753);
            panel2.TabIndex = 24;
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
            btnVolverMenu.Size = new Size(176, 47);
            btnVolverMenu.TabIndex = 30;
            btnVolverMenu.Text = "Volver";
            btnVolverMenu.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.devolucion1;
            pictureBox1.Location = new Point(12, 146);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 179);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(283, -41);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(637, 269);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.LogoEmpresa;
            pictureBox3.Location = new Point(1374, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 47);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 45;
            pictureBox3.TabStop = false;
            // 
            // Ltbpendientes
            // 
            Ltbpendientes.FormattingEnabled = true;
            Ltbpendientes.Items.AddRange(new object[] { "" });
            Ltbpendientes.Location = new Point(247, 309);
            Ltbpendientes.Name = "Ltbpendientes";
            Ltbpendientes.Size = new Size(514, 244);
            Ltbpendientes.TabIndex = 46;
            // 
            // cmbMotivo
            // 
            cmbMotivo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbMotivo.ForeColor = Color.Gray;
            cmbMotivo.FormattingEnabled = true;
            cmbMotivo.Items.AddRange(new object[] { "Para devolver", "Rechazado por el cliente", "Fuera de zona", "Dañado", "Doble etiqueta", "Cliente no disponible", "PNR Recuperado" });
            cmbMotivo.Location = new Point(478, 254);
            cmbMotivo.Name = "cmbMotivo";
            cmbMotivo.Size = new Size(283, 39);
            cmbMotivo.TabIndex = 47;
            cmbMotivo.Text = "--------Motivo--------";
            // 
            // frmRegistroPaqueteDevolucion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1422, 753);
            Controls.Add(cmbMotivo);
            Controls.Add(Ltbpendientes);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtMotivo);
            Controls.Add(lblListaPaquetes);
            Controls.Add(btnGuardar);
            MaximizeBox = false;
            Name = "frmRegistroPaqueteDevolucion";
            Text = "frmRegistroPaqueteDevolucion";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblListaPaquetes;
        private Button btnGuardar;
        private Panel panel1;
        private TextBox txtMotivo;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnVolverMenu;
        private PictureBox pictureBox3;
        private ListBox Ltbpendientes;
        private ComboBox cmbMotivo;
    }
}