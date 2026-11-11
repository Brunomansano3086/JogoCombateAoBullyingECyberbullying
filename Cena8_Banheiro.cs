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
            this.Text = "Entre o Silêncio e a Coragem";
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            btnCena8A.Text = "";
            btnCena8A.FlatStyle = FlatStyle.Flat;
            btnCena8A.BackColor = Color.Transparent;
            btnCena8A.FlatAppearance.BorderSize = 0;
            btnCena8A.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnCena8A.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);

            btnCena8B.Text = "";
            btnCena8B.FlatStyle = FlatStyle.Flat;
            btnCena8B.BackColor = Color.Transparent;
            btnCena8B.FlatAppearance.BorderSize = 0;
            btnCena8B.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnCena8B.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);

            btnCena8C.Text = "";
            btnCena8C.FlatStyle = FlatStyle.Flat;
            btnCena8C.BackColor = Color.Transparent;
            btnCena8C.FlatAppearance.BorderSize = 0;
            btnCena8C.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnCena8C.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);
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

        private void Cena8_Banheiro_FormClosing(object sender, FormClosingEventArgs e)
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
