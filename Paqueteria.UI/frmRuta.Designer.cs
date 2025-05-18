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
            listBox1 = new ListBox();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            txtCantidad = new TextBox();
            panel2 = new Panel();
            btnVolverMenu = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            comboBox2 = new ComboBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(160, 106);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(222, 39);
            comboBox1.TabIndex = 18;
            comboBox1.Text = "USUARIO DRIVER";
            // 
            // txtAgregar
            // 
            txtAgregar.Location = new Point(431, 156);
            txtAgregar.Name = "txtAgregar";
            txtAgregar.Size = new Size(111, 42);
            txtAgregar.TabIndex = 17;
            txtAgregar.Text = "AGREGAR";
            txtAgregar.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(169, 269);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(188, 452);
            listBox1.TabIndex = 14;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(397, 210);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(784, 524);
            dataGridView1.TabIndex = 20;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(169, 197);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(188, 1);
            panel1.TabIndex = 22;
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = SystemColors.ButtonHighlight;
            txtCantidad.BorderStyle = BorderStyle.None;
            txtCantidad.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCantidad.ForeColor = Color.Gray;
            txtCantidad.Location = new Point(169, 165);
            txtCantidad.MaxLength = 11;
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(188, 28);
            txtCantidad.TabIndex = 21;
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
            panel2.Size = new Size(154, 753);
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
            pictureBox1.Location = new Point(3, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(678, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(394, 154);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.logo22;
            pictureBox3.Location = new Point(201, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(126, 102);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 45;
            pictureBox3.TabStop = false;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(1209, 217);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(313, 524);
            dataGridView2.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(195, 223);
            label1.Name = "label1";
            label1.Size = new Size(132, 31);
            label1.TabIndex = 47;
            label1.Text = "CANTIDAD";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "COYOACO", "LIBRES", "SAN MIGUEL", "HUEYTAMALCO", "CUETZALAN", "ZACAPOAXTLA", "ZARAGOZA", "TLATLAUQUITEPEC", "ATEMPAN", "TETELES", "TEZIUTLAN", "ALTOTONGA", "ATZALAN", "JALAZINGO", "XIUTETELCO", "CHIGNAUTLA" });
            comboBox2.Location = new Point(1209, 160);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(313, 39);
            comboBox2.TabIndex = 48;
            comboBox2.Text = "VER POR CIUDAD";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            checkBox1.Location = new Point(1192, 105);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(165, 29);
            checkBox1.TabIndex = 49;
            checkBox1.Text = "PRECIO MENOR";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            checkBox2.Location = new Point(1363, 105);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(163, 29);
            checkBox2.TabIndex = 50;
            checkBox2.Text = "PRECIO MAYOR";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // frmRuta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1534, 753);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtCantidad);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(txtAgregar);
            Controls.Add(listBox1);
            MaximizeBox = false;
            Name = "frmRuta";
            Text = "frmRuta";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnvolver;
        private ComboBox comboBox1;
        private Button txtAgregar;
        private ListBox listBox1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private TextBox txtCantidad;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnVolverMenu;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private DataGridView dataGridView2;
        private Label label1;
        private ComboBox comboBox2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
    }
}