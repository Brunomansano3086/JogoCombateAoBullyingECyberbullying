using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;

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
            GerenciadorAudio.TocarMusicaFundo();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {

            GerenciadorAudio.PararMusicaFundo(); //para a música de fundo ao iniciar o jogo

            Pontuacao.Zerar();
            new CenaPreJogo().Show();
            this.Hide();
        }

        private void btnTema_Click(object sender, EventArgs e)
        {
            GerenciadorAudio.PararMusicaFundo(); //para a música de fundo ao abrir a explicação do bullying

            this.Hide();
            new ExplicacaoBullying().ShowDialog();
            this.Show();
            GerenciadorAudio.TocarMusicaFundo(); //retoma a música de fundo ao voltar para a tela inicial
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreditos_Click(object sender, EventArgs e)
        {
            GerenciadorAudio.PararMusicaFundo(); //para a música de fundo ao abrir os créditos

            this.Hide();
            new Creditos().ShowDialog();
            this.Show();
            GerenciadorAudio.TocarMusicaFundo(); //retoma a música de fundo ao voltar para a tela inicial
        }
    }
}
