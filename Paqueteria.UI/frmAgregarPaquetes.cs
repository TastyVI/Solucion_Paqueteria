﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paqueteria.UI
{
    public partial class frmAgregarPaquetes : Form
    {
        public frmAgregarPaquetes()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(1440, 800);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void txtId_Enter(object sender, EventArgs e)
        {
            if (txtId.Text == "ID")
            {
                txtId.Text = "";
                txtId.ForeColor = Color.Black;
            }
        }

        private void txtId_Leave(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                txtId.Text = "ID";
                txtId.ForeColor = Color.Gray;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
