namespace Paqueteria.UI
{
    partial class frmEliminarInventario
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
            panel1 = new Panel();
            txtBuscarPaquete = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnEliminar = new Button();
            listBox1 = new ListBox();
            panel5 = new Panel();
            btnVolverMenu = new Button();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            listBox2 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            panel1.Location = new Point(218, 240);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(226, 1);
            panel1.TabIndex = 47;
            // 
            // txtBuscarPaquete
            // 
            txtBuscarPaquete.BackColor = SystemColors.ButtonHighlight;
            txtBuscarPaquete.BorderStyle = BorderStyle.None;
            txtBuscarPaquete.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBuscarPaquete.ForeColor = Color.Gray;
            txtBuscarPaquete.Location = new Point(218, 195);
            txtBuscarPaquete.Name = "txtBuscarPaquete";
            txtBuscarPaquete.Size = new Size(226, 31);
            txtBuscarPaquete.TabIndex = 46;
            txtBuscarPaquete.Text = "BUSCAR PAQUETE";
            txtBuscarPaquete.Enter += txtBuscarPaquete_Enter;
            txtBuscarPaquete.Leave += txtBuscarPaquete_Leave;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dateTimePicker1.Location = new Point(218, 255);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(390, 34);
            dateTimePicker1.TabIndex = 45;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo22;
            pictureBox2.Location = new Point(169, -13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(190, 154);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 44;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(817, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(593, 285);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEliminar.Image = Properties.Resources.paneles;
            btnEliminar.ImageAlign = ContentAlignment.TopCenter;
            btnEliminar.Location = new Point(639, 251);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(145, 46);
            btnEliminar.TabIndex = 41;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(218, 318);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(566, 364);
            listBox1.TabIndex = 40;
            // 
            // panel5
            // 
            panel5.BackColor = Color.SteelBlue;
            panel5.Controls.Add(btnVolverMenu);
            panel5.Controls.Add(pictureBox3);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(163, 753);
            panel5.TabIndex = 39;
            // 
            // btnVolverMenu
            // 
            btnVolverMenu.Dock = DockStyle.Top;
            btnVolverMenu.FlatStyle = FlatStyle.Flat;
            btnVolverMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolverMenu.ForeColor = Color.White;
            btnVolverMenu.Image = Properties.Resources.paneles;
            btnVolverMenu.ImageAlign = ContentAlignment.BottomRight;
            btnVolverMenu.Location = new Point(0, 0);
            btnVolverMenu.Name = "btnVolverMenu";
            btnVolverMenu.Size = new Size(163, 43);
            btnVolverMenu.TabIndex = 29;
            btnVolverMenu.Text = "Volver";
            btnVolverMenu.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Eliminar;
            pictureBox3.Location = new Point(3, 158);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(157, 164);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 28;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(209, 112);
            label1.Name = "label1";
            label1.Size = new Size(436, 54);
            label1.TabIndex = 48;
            label1.Text = "ELIMINAR REGISTROS";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(871, 318);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(403, 364);
            listBox2.TabIndex = 49;
            // 
            // frmEliminarInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1422, 753);
            Controls.Add(listBox2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(txtBuscarPaquete);
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnEliminar);
            Controls.Add(listBox1);
            Controls.Add(panel5);
            MaximizeBox = false;
            Name = "frmEliminarInventario";
            Text = "frmEliminarInventario";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtBuscarPaquete;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnEliminar;
        private ListBox listBox1;
        private Panel panel5;
        private Button btnVolverMenu;
        private PictureBox pictureBox3;
        private Label label1;
        private ListBox listBox2;
    }
}