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
            cmbMotivo = new ComboBox();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // lblListaPaquetes
            // 
            lblListaPaquetes.AutoSize = true;
            lblListaPaquetes.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblListaPaquetes.Location = new Point(905, 255);
            lblListaPaquetes.Name = "lblListaPaquetes";
            lblListaPaquetes.Size = new Size(437, 38);
            lblListaPaquetes.TabIndex = 13;
            lblListaPaquetes.Text = "Lista de paquetes de días anterio";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Image = Properties.Resources.paneles;
            btnGuardar.ImageAlign = ContentAlignment.TopCenter;
            btnGuardar.Location = new Point(389, 587);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(191, 50);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(210, 294);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(232, 1);
            panel1.TabIndex = 22;
            // 
            // txtMotivo
            // 
            txtMotivo.BackColor = SystemColors.ButtonHighlight;
            txtMotivo.BorderStyle = BorderStyle.None;
            txtMotivo.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMotivo.ForeColor = Color.Gray;
            txtMotivo.Location = new Point(210, 262);
            txtMotivo.MaxLength = 11;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(232, 28);
            txtMotivo.TabIndex = 21;
            txtMotivo.Text = "ID PAQUETE";
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
            btnVolverMenu.Click += btnVolverMenu_Click;
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
            pictureBox3.Image = Properties.Resources.logo22;
            pictureBox3.Location = new Point(1283, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(137, 125);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 45;
            pictureBox3.TabStop = false;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(210, 326);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(580, 228);
            dataGridView1.TabIndex = 48;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(871, 325);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(539, 229);
            dataGridView2.TabIndex = 49;
            // 
            // frmRegistroPaqueteDevolucion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1422, 753);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(cmbMotivo);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtMotivo);
            Controls.Add(lblListaPaquetes);
            Controls.Add(btnGuardar);
            Controls.Add(pictureBox3);
            MaximizeBox = false;
            Name = "frmRegistroPaqueteDevolucion";
            Text = "frmRegistroPaqueteDevolucion";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
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
        private ComboBox cmbMotivo;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
    }
}