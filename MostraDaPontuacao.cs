using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JogoCombateAoBullyingECyberbullying
{
    public partial class MostraDaPontuacao : Form
    {
        public MostraDaPontuacao()
        {
            InitializeComponent();

            Fontes.Carregar();
            lblPosturaAtiva.Font = Fontes.PressStart(18);
            lblOmissao.Font = Fontes.PressStart(18);
            lblCumplicidade.Font = Fontes.PressStart(18);

            this.Text = "Entre o Silêncio e a Coragem";
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            lblPosturaAtiva.Text = Pontuacao.PosturaAtiva.ToString();
            lblOmissao.Text = Pontuacao.Omissao.ToString();
            lblCumplicidade.Text = Pontuacao.Cumplicidade.ToString();

            btnVoltarAoMenu.Text = "";
            btnVoltarAoMenu.FlatStyle = FlatStyle.Flat;
            btnVoltarAoMenu.BackColor = Color.Transparent;
            btnVoltarAoMenu.FlatAppearance.BorderSize = 0;
            btnVoltarAoMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnVoltarAoMenu.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);
        }

        private void btnVoltarAoMenu_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is TelaInicial)
                {
                    f.Show();
                    break;
                }
            }
            this.Close();
        }

        private void MostraDaPontuacao_FormClosing(object sender, FormClosingEventArgs e)
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
