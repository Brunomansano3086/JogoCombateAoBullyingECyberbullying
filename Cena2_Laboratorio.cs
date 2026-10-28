using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JogoCombateAoBullyingECyberbullying
{
    public partial class Cena2_Laboratorio : Form
    {
        public Cena2_Laboratorio()
        {
            InitializeComponent();
        }

        private void btnCena2A_Click(object sender, EventArgs e)
        {
            Pontuacao.Adicionar(TipoResposta.Omissao);
            new Cena2A().Show();
            this.Close();
        }

        private void btnCena2B_Click(object sender, EventArgs e)
        {
            Pontuacao.Adicionar(TipoResposta.Cumplicidade);
            new Cena2B().Show();
            this.Close();
        }

        private void btnCena2C_Click(object sender, EventArgs e)
        {
            Pontuacao.Adicionar(TipoResposta.PosturaAtiva);
            new Cena2C().Show();
            this.Close();
        }
    }
}
