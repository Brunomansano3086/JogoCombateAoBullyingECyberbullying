using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JogoCombateAoBullyingECyberbullying
{
    public partial class Cena1_WhatsApp : Form
    {
        public Cena1_WhatsApp()
        {
            InitializeComponent();
        }

        private void btnCena1A_Click(object sender, EventArgs e)
        {
            Pontuacao.Adicionar(TipoResposta.PosturaAtiva);
            new Cena1A().Show();
            this.Close();
        }

        private void btnCena1B_Click(object sender, EventArgs e)
        {
            Pontuacao.Adicionar(TipoResposta.Omissao);
            new Cena1B().Show();
            this.Close();
        }

        private void btnCena1C_Click(object sender, EventArgs e)
        {
            Pontuacao.Adicionar(TipoResposta.Cumplicidade);
            new Cena1C().Show();
            this.Close();
        }
    }
}
