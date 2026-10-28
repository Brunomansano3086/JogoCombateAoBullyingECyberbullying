using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JogoCombateAoBullyingECyberbullying
{
    public partial class Cena10_Estacionamento : Form
    {
        public Cena10_Estacionamento()
        {
            InitializeComponent();
        }

        private void btnCena10A_Click(object sender, EventArgs e)
        {
            Pontuacao.Adicionar(TipoResposta.Cumplicidade);
            new Cena10A().Show();
            this.Close();
        }

        private void btnCena10B_Click(object sender, EventArgs e)
        {
            Pontuacao.Adicionar(TipoResposta.Omissao);
            new Cena10B().Show();
            this.Close();
        }

        private void btnCena10C_Click(object sender, EventArgs e)
        {
            Pontuacao.Adicionar(TipoResposta.PosturaAtiva);
            new Cena10C().Show();
            this.Close();
        }
    }
}
