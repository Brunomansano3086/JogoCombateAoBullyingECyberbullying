using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JogoCombateAoBullyingECyberbullying
{
    public partial class FinalRuim : Form
    {
        public FinalRuim()
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

        private void FinalRuim_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing &&
        !Application.OpenForms.Cast<Form>().Any(f => f != this && f.Visible))
            {
                var inicial = Application.OpenForms.OfType<TelaInicial>().FirstOrDefault();
                if (inicial != null) inicial.Show();
                else new TelaInicial().Show();
            }
        }
    }
}
