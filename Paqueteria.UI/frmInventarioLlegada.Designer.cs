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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventarioLlegada));
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
            resources.ApplyResources(listBox1, "listBox1");
            listBox1.FormattingEnabled = true;
            listBox1.Name = "listBox1";
            // 
            // dataGridView1
            // 
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.BackgroundColor = Color.SteelBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Name = "dataGridView1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // txtFecha
            // 
            resources.ApplyResources(txtFecha, "txtFecha");
            txtFecha.Name = "txtFecha";
            txtFecha.ReadOnly = true;
            // 
            // txtNombre
            // 
            resources.ApplyResources(txtNombre, "txtNombre");
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(btnVolverMenu);
            panel1.Controls.Add(pictureBox3);
            panel1.Name = "panel1";
            // 
            // btnVolverMenu
            // 
            resources.ApplyResources(btnVolverMenu, "btnVolverMenu");
            btnVolverMenu.ForeColor = Color.White;
            btnVolverMenu.Image = Properties.Resources.paneles;
            btnVolverMenu.Name = "btnVolverMenu";
            btnVolverMenu.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.Image = Properties.Resources.inventario;
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Image = Properties.Resources.paneles;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            resources.ApplyResources(pictureBox4, "pictureBox4");
            pictureBox4.Image = Properties.Resources.logo22;
            pictureBox4.Name = "pictureBox4";
            pictureBox4.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // frmInventarioLlegada
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
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