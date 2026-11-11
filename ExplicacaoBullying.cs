using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JogoCombateAoBullyingECyberbullying
{
    public partial class ExplicacaoBullying : Form
    {
        public ExplicacaoBullying()
        {
            InitializeComponent();
            this.Text = "Entre o Silêncio e a Coragem";
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            this.StartPosition = FormStartPosition.CenterScreen;

            btnVoltar.Text = "";
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnVoltar.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExplicacaoBullying_FormClosing(object sender, FormClosingEventArgs e)
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
