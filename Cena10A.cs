using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JogoCombateAoBullyingECyberbullying
{
    public partial class Cena10A : Form
    {
        public Cena10A()
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
            Finais.Abrir();
            this.Close();
        }
    }
}
