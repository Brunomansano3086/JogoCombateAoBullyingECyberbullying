using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JogoCombateAoBullyingECyberbullying
{
    public partial class Cena2_Laboratorio : Form
    {
        public Cena2_Laboratorio()
        {
            InitializeComponent();

            btnCena2A.Text = "";
            btnCena2A.FlatStyle = FlatStyle.Flat;
            btnCena2A.BackColor = Color.Transparent;
            btnCena2A.FlatAppearance.BorderSize = 0;
            btnCena2A.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnCena2A.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);

            btnCena2B.Text = "";
            btnCena2B.FlatStyle = FlatStyle.Flat;
            btnCena2B.BackColor = Color.Transparent;
            btnCena2B.FlatAppearance.BorderSize = 0;
            btnCena2B.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnCena2B.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);

            btnCena2C.Text = "";
            btnCena2C.FlatStyle = FlatStyle.Flat;
            btnCena2C.BackColor = Color.Transparent;
            btnCena2C.FlatAppearance.BorderSize = 0;
            btnCena2C.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnCena2C.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);
        }

        private void btnCena2A_Click(object sender, EventArgs e)
        {
            Pontuacao.Adicionar(TipoResposta.Omissao);
            new Cena2A().Show();
            this.Close();
        }

        private void btnCena2B_Click(object sender, EventArgs e)
        {
            Pontuacao.Adicionar(TipoResposta.Cumplicidade);
            new Cena2B().Show();
            this.Close();
        }

        private void btnCena2C_Click(object sender, EventArgs e)
        {
            Pontuacao.Adicionar(TipoResposta.PosturaAtiva);
            new Cena2C().Show();
            this.Close();
        }

        private void Cena2_Laboratorio_FormClosing(object sender, FormClosingEventArgs e)
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
