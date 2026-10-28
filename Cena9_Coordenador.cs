using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JogoCombateAoBullyingECyberbullying
{
    public partial class Cena9_Coordenador : Form
    {
        public Cena9_Coordenador()
        {
            InitializeComponent();
        }

        private void btnCena9A_Click(object sender, EventArgs e)
        {
            Pontuacao.Adicionar(TipoResposta.PosturaAtiva);
            new Cena9A().Show();
            this.Close();
        }

        private void btnCena9B_Click(object sender, EventArgs e)
        {
            Pontuacao.Adicionar(TipoResposta.Omissao);
            new Cena9B().Show();
            this.Close();
        }

        private void btnCena9C_Click(object sender, EventArgs e)
        {
            Pontuacao.Adicionar(TipoResposta.Cumplicidade);
            new Cena9C().Show();
            this.Close();
        }
    }
}
