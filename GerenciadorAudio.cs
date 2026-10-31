using System;
using System.IO;
using System.Media;

namespace JogoCombateAoBullyingECyberbullying
{
    public static class GerenciadorAudio
    {
        private static SoundPlayer musicaFundo;
        private static SoundPlayer somJogo;

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
    }
}