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
            btnEliminar = new Button();
            btnAgregar = new Button();
            dataGridView1 = new DataGridView();
            pictureBox2 = new PictureBox();
            txtId = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            txtFecha = new TextBox();
            txtUbicacion = new TextBox();
            panel4 = new Panel();
            btnVolverMenu = new Button();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(149, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(269, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnEliminar
            // 
            btnEliminar.Image = Properties.Resources.paneles;
            btnEliminar.ImageAlign = ContentAlignment.TopCenter;
            btnEliminar.Location = new Point(296, 337);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(122, 56);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Image = Properties.Resources.paneles;
            btnAgregar.ImageAlign = ContentAlignment.TopCenter;
            btnAgregar.Location = new Point(158, 337);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(122, 56);
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
            dataGridView1.Location = new Point(453, 146);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(388, 247);
            dataGridView1.TabIndex = 11;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(741, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 62);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ButtonHighlight;
            txtId.BorderStyle = BorderStyle.None;
            txtId.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.ForeColor = Color.Gray;
            txtId.Location = new Point(158, 158);
            txtId.Name = "txtId";
            txtId.Size = new Size(260, 28);
            txtId.TabIndex = 13;
            txtId.Text = "ID";
            txtId.Enter += txtId_Enter;
            txtId.Leave += txtId_Leave;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(158, 190);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 1);
            panel1.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(158, 236);
            panel2.Margin = new Padding(1);
            panel2.Name = "panel2";
            panel2.Size = new Size(260, 1);
            panel2.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(158, 288);
            panel3.Margin = new Padding(1);
            panel3.Name = "panel3";
            panel3.Size = new Size(260, 1);
            panel3.TabIndex = 16;
            // 
            // txtFecha
            // 
            txtFecha.BackColor = SystemColors.ButtonHighlight;
            txtFecha.BorderStyle = BorderStyle.None;
            txtFecha.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFecha.ForeColor = Color.Gray;
            txtFecha.Location = new Point(158, 204);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(260, 28);
            txtFecha.TabIndex = 17;
            txtFecha.Text = "FECHA";
            txtFecha.Enter += txtFecha_Enter;
            txtFecha.Leave += txtFecha_Leave;
            // 
            // txtUbicacion
            // 
            txtUbicacion.BackColor = SystemColors.ButtonHighlight;
            txtUbicacion.BorderStyle = BorderStyle.None;
            txtUbicacion.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUbicacion.ForeColor = Color.Gray;
            txtUbicacion.Location = new Point(158, 256);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(260, 28);
            txtUbicacion.TabIndex = 18;
            txtUbicacion.Text = "UBICACIÓN";
            txtUbicacion.Enter += txtUbicacion_Enter;
            txtUbicacion.Leave += txtUbicacion_Leave;
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
            panel4.TabIndex = 19;
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
            pictureBox3.Image = Properties.Resources.agregarP;
            pictureBox3.Location = new Point(12, 170);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 119);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.LogoEmpresa;
            pictureBox4.Location = new Point(524, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(116, 105);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 45;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // frmAgregarPaquetes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(853, 450);
            Controls.Add(pictureBox4);
            Controls.Add(panel4);
            Controls.Add(txtUbicacion);
            Controls.Add(txtFecha);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtId);
            Controls.Add(pictureBox2);
            Controls.Add(dataGridView1);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(pictureBox1);
            Name = "frmAgregarPaquetes";
            Text = "frmPaquete";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnEliminar;
        private Button btnAgregar;
        private DataGridView dataGridView1;
        private PictureBox pictureBox2;
        private TextBox txtId;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtFecha;
        private TextBox txtUbicacion;
        private Panel panel4;
        private PictureBox pictureBox3;
        private Button btnVolverMenu;
        private PictureBox pictureBox4;
    }
}