using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JogoCombateAoBullyingECyberbullying
{
    public partial class FinalBom : Form
    {
        public FinalBom()
        {
            InitializeComponent();

            btnMostraPontuacao.Text = "";
            btnMostraPontuacao.FlatStyle = FlatStyle.Flat;
            btnMostraPontuacao.BackColor = Color.Transparent;
            btnMostraPontuacao.FlatAppearance.BorderSize = 0;
            btnMostraPontuacao.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnMostraPontuacao.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);
        }

        private void btnMostraPontuacao_Click(object sender, EventArgs e)
        {
            new MostraDaPontuacao().Show();
            this.Close();
        }
    }
}
