namespace RoboTupiniquim.ConsoleApp
{
    internal class Robo
    {
        public int x = 0;
        public int y = 0;
        public char direcao = new char();
        public string posicao = "";
        public string comandoExploracao = "";
        public char comandoAtual = new char();
        public string posicaoFinal = "";
        public int quantidade = 0;
        public int numero = 0;

        public void GirarParaEsquerda()
        {
            if (comandoAtual == 'E')
            {
                if (direcao == 'N')
                    direcao = 'O';
                else if (direcao == 'S')
                    direcao = 'L';
                else if (direcao == 'O')
                    direcao = 'S';
                else if (direcao == 'L')
                    direcao = 'N';
            }
        }

        public void GirarParaDireita()
        {
            if (comandoAtual == 'D')
            {
                if (direcao == 'N')
                    direcao = 'L';
                else if (direcao == 'S')
                    direcao = 'O';
                else if (direcao == 'O')
                    direcao = 'N';
                else if (direcao == 'L')
                    direcao = 'S';
            }
        }

        public void Mover(Local local)
        {
            if (comandoAtual == 'M' && direcao == 'N' && y < local.yMaximo)
                y++;
            else if (comandoAtual == 'M' && direcao == 'S' && y > 0)
                y--;
            else if (comandoAtual == 'M' && direcao == 'L' && x < local.xMaximo)
                x++;
            else if (comandoAtual == 'M' && direcao == 'O' && x > 0)
                x--;
        }

        public void Explorar(Local local)
        {
            char[] comandoMovimento = comandoExploracao.ToCharArray();

            for (int i = 0; i < comandoMovimento.Length; i++)
            {
                comandoAtual = comandoMovimento[i];

                GirarParaDireita();
                GirarParaEsquerda();
                Mover(local);
            }

            posicaoFinal = $"{x} {y} {direcao}";
        }
    }
}
