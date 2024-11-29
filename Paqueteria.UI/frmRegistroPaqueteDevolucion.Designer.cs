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
            lstPaquetesAnteriores = new ListBox();
            lblListaPaquetes = new Label();
            btnGuardar = new Button();
            panel1 = new Panel();
            txtMotivo = new TextBox();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnVolverMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lstPaquetesAnteriores
            // 
            lstPaquetesAnteriores.BackColor = SystemColors.InactiveBorder;
            lstPaquetesAnteriores.FormattingEnabled = true;
            lstPaquetesAnteriores.Location = new Point(610, 129);
            lstPaquetesAnteriores.Name = "lstPaquetesAnteriores";
            lstPaquetesAnteriores.Size = new Size(178, 284);
            lstPaquetesAnteriores.TabIndex = 14;
            // 
            // lblListaPaquetes
            // 
            lblListaPaquetes.AutoSize = true;
            lblListaPaquetes.Location = new Point(572, 101);
            lblListaPaquetes.Name = "lblListaPaquetes";
            lblListaPaquetes.Size = new Size(228, 20);
            lblListaPaquetes.TabIndex = 13;
            lblListaPaquetes.Text = "Lista de paquetes de días anterio";
            // 
            // btnGuardar
            // 
            btnGuardar.Image = Properties.Resources.paneles;
            btnGuardar.ImageAlign = ContentAlignment.TopCenter;
            btnGuardar.Location = new Point(319, 404);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(152, 34);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(345, 133);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(160, 1);
            panel1.TabIndex = 22;
            // 
            // txtMotivo
            // 
            txtMotivo.BackColor = SystemColors.ButtonHighlight;
            txtMotivo.BorderStyle = BorderStyle.None;
            txtMotivo.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMotivo.ForeColor = Color.Gray;
            txtMotivo.Location = new Point(345, 101);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(160, 28);
            txtMotivo.TabIndex = 21;
            txtMotivo.Text = "MOTIVO";
            txtMotivo.Enter += txtMotivo_Enter;
            txtMotivo.Leave += txtMotivo_Leave;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(195, 146);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(371, 242);
            dataGridView1.TabIndex = 23;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(btnVolverMenu);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(176, 450);
            panel2.TabIndex = 24;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.devolucion1;
            pictureBox1.Location = new Point(12, 146);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(182, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(223, 95);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
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
            btnVolverMenu.Size = new Size(176, 47);
            btnVolverMenu.TabIndex = 30;
            btnVolverMenu.Text = "Volver al Menu";
            btnVolverMenu.UseVisualStyleBackColor = true;
            // 
            // frmRegistroPaqueteDevolucion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(txtMotivo);
            Controls.Add(lstPaquetesAnteriores);
            Controls.Add(lblListaPaquetes);
            Controls.Add(btnGuardar);
            Name = "frmRegistroPaqueteDevolucion";
            Text = "frmRegistroPaqueteDevolucion";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox lstPaquetesAnteriores;
        private Label lblListaPaquetes;
        private Button btnGuardar;
        private Panel panel1;
        private TextBox txtMotivo;
        private DataGridView dataGridView1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnVolverMenu;
    }
}