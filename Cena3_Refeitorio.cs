using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JogoCombateAoBullyingECyberbullying
{
    public partial class Cena3_Refeitorio : Form
    {
        public Cena3_Refeitorio()
        {
            InitializeComponent();

            btnCena3A.Text = "";
            btnCena3A.FlatStyle = FlatStyle.Flat;
            btnCena3A.BackColor = Color.Transparent;
            btnCena3A.FlatAppearance.BorderSize = 0;
            btnCena3A.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnCena3A.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);

            btnCena3B.Text = "";
            btnCena3B.FlatStyle = FlatStyle.Flat;
            btnCena3B.BackColor = Color.Transparent;
            btnCena3B.FlatAppearance.BorderSize = 0;
            btnCena3B.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnCena3B.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);

            btnCena3C.Text = "";
            btnCena3C.FlatStyle = FlatStyle.Flat;
            btnCena3C.BackColor = Color.Transparent;
            btnCena3C.FlatAppearance.BorderSize = 0;
            btnCena3C.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnCena3C.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);
        }

        private void btnCena3A_Click(object sender, EventArgs e)
        {
            Pontuacao.Adicionar(TipoResposta.PosturaAtiva);
            new Cena3A().Show();
            this.Close();
        }

        private void btnCena3B_Click(object sender, EventArgs e)
        {
            Pontuacao.Adicionar(TipoResposta.Cumplicidade);
            new Cena3B().Show();
            this.Close();
        }

        private void btnCena3C_Click(object sender, EventArgs e)
        {
            Pontuacao.Adicionar(TipoResposta.Omissao);
            new Cena3C().Show();
            this.Close();
        }
    }
}
