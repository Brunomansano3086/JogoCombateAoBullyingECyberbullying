using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JogoCombateAoBullyingECyberbullying
{
    public partial class Cena5_GitHub : Form
    {
        public Cena5_GitHub()
        {
            InitializeComponent();
        }

        private void btnCena5A_Click(object sender, EventArgs e)
        {
            Pontuacao.Adicionar(TipoResposta.Cumplicidade);
            new Cena5A().Show();
            this.Close();
        }

        private void btnCena5B_Click(object sender, EventArgs e)
        {
            Pontuacao.Adicionar(TipoResposta.Omissao);
            new Cena5B().Show();
            this.Close();
        }

        private void btnCena5C_Click(object sender, EventArgs e)
        {
            Pontuacao.Adicionar(TipoResposta.PosturaAtiva);
            new Cena5C().Show();
            this.Close();
        }
    }
}
