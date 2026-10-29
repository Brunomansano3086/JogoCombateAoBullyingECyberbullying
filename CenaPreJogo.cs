using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JogoCombateAoBullyingECyberbullying
{
    public partial class CenaPreJogo : Form
    {
        public CenaPreJogo()
        {
            InitializeComponent();

            btnComecarJogo.Text = "";
            btnComecarJogo.FlatStyle = FlatStyle.Flat;
            btnComecarJogo.BackColor = Color.Transparent;
            btnComecarJogo.FlatAppearance.BorderSize = 0;
            btnComecarJogo.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnComecarJogo.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);
        }

        private void btnComecarJogo_Click(object sender, EventArgs e)
        {
            new Cena1_WhatsApp().Show();
            this.Close();
        }
    }
}
