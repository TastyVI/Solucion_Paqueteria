namespace Paqueteria.UI
{
    partial class frmInventarioLlegada
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
            listBox1 = new ListBox();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            txtFecha = new TextBox();
            txtNombre = new TextBox();
            panel1 = new Panel();
            btnVolverMenu = new Button();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            pictureBox4 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(192, 214);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(499, 504);
            listBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.SteelBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(809, 192);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(610, 490);
            dataGridView1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(818, -71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(529, 257);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // txtFecha
            // 
            txtFecha.Font = new Font("Segoe UI", 12F);
            txtFecha.Location = new Point(445, 162);
            txtFecha.Name = "txtFecha";
            txtFecha.ReadOnly = true;
            txtFecha.Size = new Size(150, 34);
            txtFecha.TabIndex = 7;
            txtFecha.Text = "FECHA";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(192, 162);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(227, 34);
            txtNombre.TabIndex = 8;
            txtNombre.Text = "NOMBRE";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(btnVolverMenu);
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(161, 753);
            panel1.TabIndex = 10;
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
            btnVolverMenu.Size = new Size(161, 43);
            btnVolverMenu.TabIndex = 10;
            btnVolverMenu.Text = "Volver";
            btnVolverMenu.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.inventario;
            pictureBox3.Location = new Point(6, 140);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(149, 169);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Image = Properties.Resources.paneles;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(635, 162);
            button1.Name = "button1";
            button1.Size = new Size(115, 36);
            button1.TabIndex = 11;
            button1.Text = "BUSCAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.LogoEmpresa;
            pictureBox4.Location = new Point(179, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(56, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 45;
            pictureBox4.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(179, 63);
            label2.Name = "label2";
            label2.Size = new Size(506, 50);
            label2.TabIndex = 47;
            label2.Text = "INVENTARIO DE DESCARGA";
            // 
            // frmInventarioLlegada
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1422, 753);
            Controls.Add(label2);
            Controls.Add(pictureBox4);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(txtNombre);
            Controls.Add(txtFecha);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(listBox1);
            MaximizeBox = false;
            Name = "frmInventarioLlegada";
            Text = "frmInventarioLlegada";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBox1;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private TextBox txtFecha;
        private TextBox txtNombre;
        private Panel panel1;
        private PictureBox pictureBox3;
        private Button button1;
        private Button btnVolverMenu;
        private PictureBox pictureBox4;
        private Label label2;
    }
}