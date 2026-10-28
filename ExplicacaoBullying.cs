using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JogoCombateAoBullyingECyberbullying
{
    public partial class ExplicacaoBullying : Form
    {
        public ExplicacaoBullying()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            btnVoltar.Text = "";
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnVoltar.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
