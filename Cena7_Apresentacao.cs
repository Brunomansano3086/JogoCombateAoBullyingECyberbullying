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
