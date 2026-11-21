using System;
using System.Drawing;
using System.Drawing.Text;
using System.Reflection;
using System.Runtime.InteropServices;

namespace JogoCombateAoBullyingECyberbullying
{
    public static class Fontes
    {
        private static readonly PrivateFontCollection colecao = new PrivateFontCollection();
        private static bool carregada = false;

        public static void Carregar()
        {
            if (carregada) return;

            var assembly = Assembly.GetExecutingAssembly();
            string recurso = "JogoCombateAoBullyingECyberbullying.Fontes.PressStart2P-Regular.ttf";

            using (var stream = assembly.GetManifestResourceStream(recurso))
            {
                if (stream == null)
                    throw new Exception("Fonte não encontrada. Confira o nome do recurso.");

                byte[] dados = new byte[stream.Length];
                stream.ReadExactly(dados, 0, dados.Length);

                IntPtr ptr = Marshal.AllocCoTaskMem(dados.Length);
                Marshal.Copy(dados, 0, ptr, dados.Length);
                colecao.AddMemoryFont(ptr, dados.Length);
            }

            carregada = true;
        }

        public static Font PressStart(float tamanho, FontStyle estilo = FontStyle.Regular)
        {
            return new Font(colecao.Families[0], tamanho, estilo);
        }
    }
}