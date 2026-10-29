using System.Windows.Forms;

namespace JogoCombateAoBullyingECyberbullying
{
    public static class Finais
    {
        public static void Abrir()
        {
            int ativa = Pontuacao.PosturaAtiva;
            int omissao = Pontuacao.Omissao;
            int cumplic = Pontuacao.Cumplicidade;

            Form final;

            if (ativa > omissao && ativa > cumplic)
            {
                // postura ativa só vence se for maior que as duas
                final = new FinalBom();
            }
            else if (cumplic >= omissao && cumplic >= ativa)
            {
                // cumplicidade vence sozinha ou em qualquer empate
                final = new FinalRuim();
            }
            else if (omissao >= ativa && omissao >= cumplic)
            {
                // omissão vence sozinha ou empatada com postura ativa
                final = new FinalIntermediario();
            }
            else
            {
                // nunca deve cair aqui, mas o C# exige o else
                final = new FinalIntermediario();
            }

            final.Show();
        }
    }
}