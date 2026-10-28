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
            this.StartPosition = FormStartPosition.CenterScreen;

            btnJogar.Text = ""; // <--- APAGA O TEXTO SOBREPOSTO
            btnJogar.FlatStyle = FlatStyle.Flat;
            btnJogar.BackColor = Color.Transparent;
            btnJogar.FlatAppearance.BorderSize = 0; // <--- REMOVE A BORDA RETANGULAR
            btnJogar.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnJogar.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);

            btnTema.Text = "";
            btnTema.FlatStyle = FlatStyle.Flat;
            btnTema.BackColor = Color.Transparent;
            btnTema.FlatAppearance.BorderSize = 0;
            btnTema.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnTema.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);

            btnSair.Text = "";
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.BackColor = Color.Transparent;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnSair.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);

            btnCreditos.Text = "";
            btnCreditos.FlatStyle = FlatStyle.Flat;
            btnCreditos.BackColor = Color.Transparent;
            btnCreditos.FlatAppearance.BorderSize = 0;
            btnCreditos.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 255, 255, 255);
            btnCreditos.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            Pontuacao.Zerar();
            new Cena1_WhatsApp().Show();
            this.Hide();
        }

        private void btnTema_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ExplicacaoBullying().ShowDialog();
            this.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreditos_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Creditos().ShowDialog();
            this.Show();
        }
    }
}
