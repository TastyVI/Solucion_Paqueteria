namespace Paqueteria.UI
{
    partial class frmRuta
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
            comboBox1 = new ComboBox();
            txtAgregar = new Button();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            txtCantidad = new TextBox();
            panel2 = new Panel();
            btnVolverMenu = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(169, 97);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(158, 28);
            comboBox1.TabIndex = 18;
            comboBox1.Text = "Usuario Chofer";
            // 
            // txtAgregar
            // 
            txtAgregar.Location = new Point(408, 399);
            txtAgregar.Name = "txtAgregar";
            txtAgregar.Size = new Size(224, 29);
            txtAgregar.TabIndex = 17;
            txtAgregar.Text = "AGREGAR";
            txtAgregar.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(686, 62);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(150, 324);
            listBox2.TabIndex = 16;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(169, 209);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 224);
            listBox1.TabIndex = 14;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(330, 131);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(350, 255);
            dataGridView1.TabIndex = 20;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(169, 183);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(158, 1);
            panel1.TabIndex = 22;
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = SystemColors.ButtonHighlight;
            txtCantidad.BorderStyle = BorderStyle.None;
            txtCantidad.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCantidad.ForeColor = Color.Gray;
            txtCantidad.Location = new Point(169, 151);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(158, 28);
            txtCantidad.TabIndex = 21;
            txtCantidad.Text = "CANTIDAD";
            txtCantidad.Enter += txtCantidad_Enter;
            txtCantidad.Leave += txtCantidad_Leave;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(btnVolverMenu);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(154, 469);
            panel2.TabIndex = 23;
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
            btnVolverMenu.Size = new Size(154, 43);
            btnVolverMenu.TabIndex = 30;
            btnVolverMenu.Text = "Volver al Menu";
            btnVolverMenu.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ruta;
            pictureBox1.Location = new Point(12, 183);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(387, 17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(245, 101);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.LogoEmpresa;
            pictureBox3.Location = new Point(211, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(53, 39);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 45;
            pictureBox3.TabStop = false;
            // 
            // frmRuta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(876, 469);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtCantidad);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(txtAgregar);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "frmRuta";
            Text = "frmRuta";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnvolver;
        private ComboBox comboBox1;
        private Button txtAgregar;
        private ListBox listBox2;
        private ListBox listBox1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private TextBox txtCantidad;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnVolverMenu;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}