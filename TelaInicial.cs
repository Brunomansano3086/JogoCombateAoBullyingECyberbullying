using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JogoCombateAoBullyingECyberbullying
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();

            btnJogar.BackColor = Color.Transparent;
            btnJogar.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnJogar.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);

            btnTema.BackColor = Color.Transparent;
            btnTema.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnTema.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);

            btnSair.BackColor = Color.Transparent;
            btnSair.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnSair.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);

            btnCreditos.BackColor = Color.Transparent;
            btnCreditos.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnCreditos.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }

        private void btnJogar_Click(object sender, EventArgs e)
        {

        }

        private void btnTema_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreditos_Click(object sender, EventArgs e)
        {

        }
    }
}
