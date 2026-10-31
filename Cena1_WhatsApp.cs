using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JogoCombateAoBullyingECyberbullying
{
    public partial class Cena1_WhatsApp : Form
    {
        public Cena1_WhatsApp()
        {
            InitializeComponent();

            btnCena1A.Text = "";
            btnCena1A.FlatStyle = FlatStyle.Flat;
            btnCena1A.BackColor = Color.Transparent;
            btnCena1A.FlatAppearance.BorderSize = 0;
            btnCena1A.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnCena1A.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);

            btnCena1B.Text = "";
            btnCena1B.FlatStyle = FlatStyle.Flat;
            btnCena1B.BackColor = Color.Transparent;
            btnCena1B.FlatAppearance.BorderSize = 0;
            btnCena1B.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnCena1B.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);

            btnCena1C.Text = "";
            btnCena1C.FlatStyle = FlatStyle.Flat;
            btnCena1C.BackColor = Color.Transparent;
            btnCena1C.FlatAppearance.BorderSize = 0;
            btnCena1C.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnCena1C.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);
        }

        private void btnCena1A_Click(object sender, EventArgs e)
        {
            Pontuacao.Adicionar(TipoResposta.PosturaAtiva);
            new Cena1A().Show();
            this.Close();
        }

        private void btnCena1B_Click(object sender, EventArgs e)
        {
            Pontuacao.Adicionar(TipoResposta.Omissao);
            new Cena1B().Show();
            this.Close();
        }

        private void btnCena1C_Click(object sender, EventArgs e)
        {
            Pontuacao.Adicionar(TipoResposta.Cumplicidade);
            new Cena1C().Show();
            this.Close();
        }

        private void Cena1_WhatsApp_FormClosing(object sender, FormClosingEventArgs e)
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
