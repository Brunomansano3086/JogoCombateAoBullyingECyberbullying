using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JogoCombateAoBullyingECyberbullying
{
    public partial class Cena7_Apresentacao : Form
    {
        public Cena7_Apresentacao()
        {
            InitializeComponent();

            btnCena7A.Text = "";
            btnCena7A.FlatStyle = FlatStyle.Flat;
            btnCena7A.BackColor = Color.Transparent;
            btnCena7A.FlatAppearance.BorderSize = 0;
            btnCena7A.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnCena7A.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);

            btnCena7B.Text = "";
            btnCena7B.FlatStyle = FlatStyle.Flat;
            btnCena7B.BackColor = Color.Transparent;
            btnCena7B.FlatAppearance.BorderSize = 0;
            btnCena7B.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnCena7B.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);

            btnCena7C.Text = "";
            btnCena7C.FlatStyle = FlatStyle.Flat;
            btnCena7C.BackColor = Color.Transparent;
            btnCena7C.FlatAppearance.BorderSize = 0;
            btnCena7C.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnCena7C.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);
        }

        private void btnCena7A_Click(object sender, EventArgs e)
        {
            Pontuacao.Adicionar(TipoResposta.Cumplicidade);
            new Cena7A().Show();
            this.Close();
        }

        private void btnCena7B_Click(object sender, EventArgs e)
        {
            Pontuacao.Adicionar(TipoResposta.Omissao);
            new Cena7B().Show();
            this.Close();
        }

        private void btnCena7C_Click(object sender, EventArgs e)
        {
            Pontuacao.Adicionar(TipoResposta.PosturaAtiva);
            new Cena7C().Show();
            this.Close();
        }
    }
}
