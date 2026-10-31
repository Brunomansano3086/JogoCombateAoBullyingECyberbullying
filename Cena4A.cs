using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JogoCombateAoBullyingECyberbullying
{
    public partial class Cena4A : Form
    {
        public Cena4A()
        {
            InitializeComponent();

            btnProximo.Text = "";
            btnProximo.FlatStyle = FlatStyle.Flat;
            btnProximo.BackColor = Color.Transparent;
            btnProximo.FlatAppearance.BorderSize = 0;
            btnProximo.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnProximo.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            new Cena5_GitHub().Show();
            this.Close();
        }

        private void Cena4A_FormClosing(object sender, FormClosingEventArgs e)
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
