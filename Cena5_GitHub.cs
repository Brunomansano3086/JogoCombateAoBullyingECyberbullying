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
            this.Text = "Entre o Silêncio e a Coragem";
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            btnCena5A.Text = "";
            btnCena5A.FlatStyle = FlatStyle.Flat;
            btnCena5A.BackColor = Color.Transparent;
            btnCena5A.FlatAppearance.BorderSize = 0;
            btnCena5A.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnCena5A.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);

            btnCena5B.Text = "";
            btnCena5B.FlatStyle = FlatStyle.Flat;
            btnCena5B.BackColor = Color.Transparent;
            btnCena5B.FlatAppearance.BorderSize = 0;
            btnCena5B.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnCena5B.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);

            btnCena5C.Text = "";
            btnCena5C.FlatStyle = FlatStyle.Flat;
            btnCena5C.BackColor = Color.Transparent;
            btnCena5C.FlatAppearance.BorderSize = 0;
            btnCena5C.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnCena5C.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);
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

        private void Cena5_GitHub_FormClosing(object sender, FormClosingEventArgs e)
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
