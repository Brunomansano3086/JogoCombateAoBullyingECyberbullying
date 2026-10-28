using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JogoCombateAoBullyingECyberbullying
{
    public partial class Cena8_Banheiro : Form
    {
        public Cena8_Banheiro()
        {
            InitializeComponent();
        }

        private void btnCena8A_Click(object sender, EventArgs e)
        {
            Pontuacao.Adicionar(TipoResposta.Cumplicidade);
            new Cena8A().Show();
            this.Close();
        }

        private void btnCena8B_Click(object sender, EventArgs e)
        {
            Pontuacao.Adicionar(TipoResposta.PosturaAtiva);
            new Cena8B().Show();
            this.Close();
        }

        private void btnCena8C_Click(object sender, EventArgs e)
        {
            Pontuacao.Adicionar(TipoResposta.Omissao);
            new Cena8C().Show();
            this.Close();
        }
    }
}
