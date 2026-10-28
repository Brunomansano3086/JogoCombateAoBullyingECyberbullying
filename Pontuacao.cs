namespace JogoCombateAoBullyingECyberbullying
{
    public enum TipoResposta
    {
        PosturaAtiva,
        Omissao,
        Cumplicidade
    }

    public static class Pontuacao
    {
        public static int PosturaAtiva { get; private set; }
        public static int Omissao { get; private set; }
        public static int Cumplicidade { get; private set; }

        public static void Adicionar(TipoResposta tipo)
        {
            switch (tipo)
            {
                case TipoResposta.PosturaAtiva:
                    PosturaAtiva++;
                    break;
                case TipoResposta.Omissao:
                    Omissao++;
                    break;
                case TipoResposta.Cumplicidade:
                    Cumplicidade++;
                    break;
            }
        }

        public static void Zerar()
        {
            PosturaAtiva = 0;
            Omissao = 0;
            Cumplicidade = 0;
        }
    }
}