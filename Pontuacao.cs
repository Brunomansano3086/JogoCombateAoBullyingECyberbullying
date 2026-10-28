namespace JogoCombateAoBullyingECyberbullying
{
    public enum TipoResposta
    {
        Omissao,
        Participacao,
        Correto
    }

    public static class Pontuacao
    {
        public static int Omissao { get; private set; }
        public static int Participacao { get; private set; }
        public static int Correto { get; private set; }

        public static void Adicionar(TipoResposta tipo)
        {
            switch (tipo)
            {
                case TipoResposta.Omissao:
                    Omissao++;
                    break;
                case TipoResposta.Participacao:
                    Participacao++;
                    break;
                case TipoResposta.Correto:
                    Correto++;
                    break;
            }
        }

        public static void Zerar()
        {
            Omissao = 0;
            Participacao = 0;
            Correto = 0;
        }
    }
}