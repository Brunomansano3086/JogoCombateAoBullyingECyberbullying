using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JogoCombateAoBullyingECyberbullying
{
    public partial class CenaPreJogo : Form
    {
        public CenaPreJogo()
        {
            InitializeComponent();
            this.Text = "Entre o Silêncio e a Coragem";
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            btnComecarJogo.Text = "";
            btnComecarJogo.FlatStyle = FlatStyle.Flat;
            btnComecarJogo.BackColor = Color.Transparent;
            btnComecarJogo.FlatAppearance.BorderSize = 0;
            btnComecarJogo.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnComecarJogo.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);
        }

        private void btnComecarJogo_Click(object sender, EventArgs e)
        {
            new Cena1_WhatsApp().Show();
            this.Close();
        }

        private void CenaPreJogo_FormClosing(object sender, FormClosingEventArgs e)
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
