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
