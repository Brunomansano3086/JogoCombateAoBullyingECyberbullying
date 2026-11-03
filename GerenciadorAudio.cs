using System;
using System.IO;
using System.Media;

namespace JogoCombateAoBullyingECyberbullying
{
    public static class GerenciadorAudio
    {
        private static SoundPlayer musicaFundo;
        private static SoundPlayer somJogo;
        private static SoundPlayer somFinalBom;
        private static SoundPlayer somFinalRuim;
        private static SoundPlayer somFinalOmissao;
        private static SoundPlayer somOpcaoBom;
        private static SoundPlayer somOpcaoRuim;
        private static SoundPlayer somOpcaoOmissao;

        // Inicializador estático: roda automaticamente na primeira vez que a classe for usada
        static GerenciadorAudio()
        {
            string pastaSons = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sons");

            string caminhoMusica = Path.Combine(pastaSons, "MusicaFundo.wav");
            if (File.Exists(caminhoMusica))
            {
                musicaFundo = new SoundPlayer(caminhoMusica);
            }

            string caminhoFundoJogo = Path.Combine(pastaSons, "MusicaJogar.wav");
            if (File.Exists(caminhoFundoJogo))
            {
                somJogo = new SoundPlayer(caminhoFundoJogo);
                somJogo.Load();
            }

            string caminhoFinalBom = Path.Combine(pastaSons, "FinalBom.wav");
            if (File.Exists(caminhoFinalBom))
            {
                somFinalBom = new SoundPlayer(caminhoFinalBom);
                somFinalBom.Load();
            }
            string caminhoFinalRuim = Path.Combine(pastaSons, "FinalRuim.wav");
            if (File.Exists(caminhoFinalRuim))
            {
                somFinalRuim = new SoundPlayer(caminhoFinalRuim);
                somFinalRuim.Load();
            }
            string caminhoFinalOmissao = Path.Combine(pastaSons, "FinalOmissao.wav");
            if (File.Exists(caminhoFinalOmissao))
            {
                somFinalOmissao = new SoundPlayer(caminhoFinalOmissao);
                somFinalOmissao.Load();
            }
            string caminhoOpcaoBom = Path.Combine(pastaSons, "OpcaoBom.wav");
            if (File.Exists(caminhoOpcaoBom))
            {
                somOpcaoBom = new SoundPlayer(caminhoOpcaoBom);
                somOpcaoBom.Load();
            }
            string caminhoOpcaoRuim = Path.Combine(pastaSons, "OpcaoRuim.wav");
            if (File.Exists(caminhoOpcaoRuim))
            {
                somOpcaoRuim = new SoundPlayer(caminhoOpcaoRuim);
                somOpcaoRuim.Load();
            }
            string caminhoOpcaoOmissao = Path.Combine(pastaSons, "OpcaoOmissao.wav");
            if (File.Exists(caminhoOpcaoOmissao))
            {
                somOpcaoOmissao = new SoundPlayer(caminhoOpcaoOmissao);
                somOpcaoOmissao.Load();
            }
        }

        public static void TocarMusicaFundo()
        {
            musicaFundo?.PlayLooping();
        }

        public static void PararMusicaFundo()
        {
            musicaFundo?.Stop();
        }

        public static void TocarMusicaJogo()
        {
            somJogo?.PlayLooping();
        }
        public static void PararMusicaJogo()
        {
            somJogo?.Stop();
        }
        public static void TocarSomFinalBom()
        {
            somFinalBom?.Play();
        }
        public static void PararSomFinalBom()
        {
            somFinalBom?.Stop();
        }
        public static void TocarSomFinalRuim()
        {
            somFinalRuim?.Play();
        }
        public static void PararSomFinalRuim()
        {
            somFinalRuim?.Stop();
        }
        public static void TocarSomFinalOmissao()
        {
            somFinalOmissao?.Play();
        }
        public static void PararSomFinalOmissao()
        {
            somFinalOmissao?.Stop();
        }
        public static void TocarSomOpcaoBom()
        {
            somOpcaoBom?.Play();
        }
        public static void PararSomOpcaoBom()
        {
            somOpcaoBom?.Stop();
        }
        public static void TocarSomOpcaoRuim()
        {
            somOpcaoRuim?.Play();
        }
        public static void PararSomOpcaoRuim()
        {
            somOpcaoRuim?.Stop();
        }
        public static void TocarSomOpcaoOmissao()
        {
            somOpcaoOmissao?.Play();
        }
        public static void PararSomOpcaoOmissao()
        {
            somOpcaoOmissao?.Stop();
        }

    }
}