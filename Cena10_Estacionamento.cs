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
            this.Text = "Entre o Silêncio e a Coragem";
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            btnCena10A.Text = "";
            btnCena10A.FlatStyle = FlatStyle.Flat;
            btnCena10A.BackColor = Color.Transparent;
            btnCena10A.FlatAppearance.BorderSize = 0;
            btnCena10A.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnCena10A.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);

            btnCena10B.Text = "";
            btnCena10B.FlatStyle = FlatStyle.Flat;
            btnCena10B.BackColor = Color.Transparent;
            btnCena10B.FlatAppearance.BorderSize = 0;
            btnCena10B.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnCena10B.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);

            btnCena10C.Text = "";
            btnCena10C.FlatStyle = FlatStyle.Flat;
            btnCena10C.BackColor = Color.Transparent;
            btnCena10C.FlatAppearance.BorderSize = 0;
            btnCena10C.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnCena10C.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);
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

        private void Cena10_Estacionamento_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing &&
        !Application.OpenForms.Cast<Form>().Any(f => f != this && f.Visible))
            {
                var inicial = Application.OpenForms.OfType<TelaInicial>().FirstOrDefault();
                if (inicial != null) inicial.Show();
                else new TelaInicial().Show();
            }
        }
    }
}
