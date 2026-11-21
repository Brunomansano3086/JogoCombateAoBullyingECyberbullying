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
            this.Text = "Entre o Silêncio e a Coragem";
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            btnCena9A.Text = "";
            btnCena9A.FlatStyle = FlatStyle.Flat;
            btnCena9A.BackColor = Color.Transparent;
            btnCena9A.FlatAppearance.BorderSize = 0;
            btnCena9A.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnCena9A.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);

            btnCena9B.Text = "";
            btnCena9B.FlatStyle = FlatStyle.Flat;
            btnCena9B.BackColor = Color.Transparent;
            btnCena9B.FlatAppearance.BorderSize = 0;
            btnCena9B.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnCena9B.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);

            btnCena9C.Text = "";
            btnCena9C.FlatStyle = FlatStyle.Flat;
            btnCena9C.BackColor = Color.Transparent;
            btnCena9C.FlatAppearance.BorderSize = 0;
            btnCena9C.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnCena9C.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter || keyData == Keys.Space)
                return true; // ignora a tecla
            return base.ProcessCmdKey(ref msg, keyData);
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

        private void Cena9_Coordenador_FormClosing(object sender, FormClosingEventArgs e)
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
