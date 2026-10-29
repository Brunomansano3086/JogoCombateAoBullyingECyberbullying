using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JogoCombateAoBullyingECyberbullying
{
    public partial class Cena4_Discord : Form
    {
        public Cena4_Discord()
        {
            InitializeComponent();

            btnCena4A.Text = "";
            btnCena4A.FlatStyle = FlatStyle.Flat;
            btnCena4A.BackColor = Color.Transparent;
            btnCena4A.FlatAppearance.BorderSize = 0;
            btnCena4A.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnCena4A.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);

            btnCena4B.Text = "";
            btnCena4B.FlatStyle = FlatStyle.Flat;
            btnCena4B.BackColor = Color.Transparent;
            btnCena4B.FlatAppearance.BorderSize = 0;
            btnCena4B.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnCena4B.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);

            btnCena4C.Text = "";
            btnCena4C.FlatStyle = FlatStyle.Flat;
            btnCena4C.BackColor = Color.Transparent;
            btnCena4C.FlatAppearance.BorderSize = 0;
            btnCena4C.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnCena4C.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);
        }

        private void btnCena4A_Click(object sender, EventArgs e)
        {
            Pontuacao.Adicionar(TipoResposta.Omissao);
            new Cena4A().Show();
            this.Close();
        }

        private void btnCena4B_Click(object sender, EventArgs e)
        {
            Pontuacao.Adicionar(TipoResposta.Cumplicidade);
            new Cena4B().Show();
            this.Close();
        }

        private void btnCena4C_Click(object sender, EventArgs e)
        {
            Pontuacao.Adicionar(TipoResposta.PosturaAtiva);
            new Cena4C().Show();
            this.Close();
        }
    }
}
