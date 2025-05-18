namespace Paqueteria.UI
{
    partial class frmAgregarPaquetes
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
            dataGridView1 = new DataGridView();
            txtId = new TextBox();
            panel1 = new Panel();
            panel4 = new Panel();
            btnVolverMenu = new Button();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            cmbAsignacion = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            dtFecha = new DateTimePicker();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(782, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(628, 231);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnAgregar
            // 
            btnAgregar.Image = Properties.Resources.paneles;
            btnAgregar.ImageAlign = ContentAlignment.TopCenter;
            btnAgregar.Location = new Point(221, 459);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(152, 64);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.SteelBlue;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(644, 308);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(748, 420);
            dataGridView1.TabIndex = 11;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ButtonHighlight;
            txtId.BorderStyle = BorderStyle.None;
            txtId.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.ForeColor = Color.Gray;
            txtId.Location = new Point(221, 332);
            txtId.MaxLength = 10;
            txtId.Name = "txtId";
            txtId.Size = new Size(334, 28);
            txtId.TabIndex = 13;
            txtId.Text = "ID";
            txtId.Enter += txtId_Enter;
            txtId.Leave += txtId_Leave;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(221, 369);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 1);
            panel1.TabIndex = 14;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SteelBlue;
            panel4.Controls.Add(btnVolverMenu);
            panel4.Controls.Add(pictureBox3);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(167, 753);
            panel4.TabIndex = 19;
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
            btnVolverMenu.Size = new Size(167, 49);
            btnVolverMenu.TabIndex = 10;
            btnVolverMenu.Text = "Volver";
            btnVolverMenu.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.agregarP;
            pictureBox3.Location = new Point(0, 164);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(164, 154);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.logo22;
            pictureBox4.Location = new Point(173, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(147, 128);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 45;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // cmbAsignacion
            // 
            cmbAsignacion.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbAsignacion.FormattingEnabled = true;
            cmbAsignacion.Items.AddRange(new object[] { "Inventario de Llegada", "Escaneo de Ruta" });
            cmbAsignacion.Location = new Point(221, 272);
            cmbAsignacion.Name = "cmbAsignacion";
            cmbAsignacion.Size = new Size(334, 39);
            cmbAsignacion.TabIndex = 47;
            cmbAsignacion.Text = "SELECCION DE BUSQUEDA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(221, 98);
            label2.Name = "label2";
            label2.Size = new Size(334, 46);
            label2.TabIndex = 50;
            label2.Text = "Agregar o Eliminar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(221, 144);
            label3.Name = "label3";
            label3.Size = new Size(211, 46);
            label3.TabIndex = 51;
            label3.Text = "Un Paquete";
            // 
            // dtFecha
            // 
            dtFecha.Location = new Point(221, 390);
            dtFecha.MaxDate = new DateTime(2099, 12, 31, 0, 0, 0, 0);
            dtFecha.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(334, 30);
            dtFecha.TabIndex = 52;
            // 
            // btnEliminar
            // 
            btnEliminar.Image = Properties.Resources.paneles;
            btnEliminar.ImageAlign = ContentAlignment.TopCenter;
            btnEliminar.Location = new Point(403, 459);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(152, 64);
            btnEliminar.TabIndex = 53;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // frmAgregarPaquetes
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1422, 753);
            Controls.Add(btnEliminar);
            Controls.Add(dtFecha);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbAsignacion);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(txtId);
            Controls.Add(dataGridView1);
            Controls.Add(btnAgregar);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            Name = "frmAgregarPaquetes";
            Text = "frmPaquete";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnAgregar;
        private DataGridView dataGridView1;
        private TextBox txtId;
        private Panel panel1;
        private Panel panel4;
        private PictureBox pictureBox3;
        private Button btnVolverMenu;
        private PictureBox pictureBox4;
        private ComboBox cmbAsignacion;
        private Label label2;
        private Label label3;
        private DateTimePicker dtFecha;
        private Button btnEliminar;
    }
}