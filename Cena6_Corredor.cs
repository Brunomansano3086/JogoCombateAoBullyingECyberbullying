using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JogoCombateAoBullyingECyberbullying
{
    public partial class Cena6_Corredor : Form
    {
        public Cena6_Corredor()
        {
            InitializeComponent();

            btnCena6A.Text = "";
            btnCena6A.FlatStyle = FlatStyle.Flat;
            btnCena6A.BackColor = Color.Transparent;
            btnCena6A.FlatAppearance.BorderSize = 0;
            btnCena6A.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnCena6A.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);

            btnCena6B.Text = "";
            btnCena6B.FlatStyle = FlatStyle.Flat;
            btnCena6B.BackColor = Color.Transparent;
            btnCena6B.FlatAppearance.BorderSize = 0;
            btnCena6B.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnCena6B.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);

            btnCena6C.Text = "";
            btnCena6C.FlatStyle = FlatStyle.Flat;
            btnCena6C.BackColor = Color.Transparent;
            btnCena6C.FlatAppearance.BorderSize = 0;
            btnCena6C.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnCena6C.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);
        }

        private void btnCena6A_Click(object sender, EventArgs e)
        {
            Pontuacao.Adicionar(TipoResposta.Omissao);
            new Cena6A().Show();
            this.Close();
        }

        private void btnCena6B_Click(object sender, EventArgs e)
        {
            Pontuacao.Adicionar(TipoResposta.Cumplicidade);
            new Cena6B().Show();
            this.Close();
        }

        private void btnCena6C_Click(object sender, EventArgs e)
        {
            Pontuacao.Adicionar(TipoResposta.PosturaAtiva);
            new Cena6C().Show();
            this.Close();
        }
    }
}
