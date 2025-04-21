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

        public bool PosicaoInicialDefinida()
        {
            try
            {
                string[] posicaoAtual = posicao.Split(' ');

                x = int.Parse(posicaoAtual[0]);
                y = int.Parse(posicaoAtual[1]);
                direcao = char.Parse(posicaoAtual[2]);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool PosicaoInicialValida(Local local)
        {
            bool posicaoValida = false;

            if (x > local.xMaximo || x < 0)
                posicaoValida = false;
            else if (y > local.yMaximo || y < 0)
                posicaoValida = false;
            else if (direcao != 'N' && direcao != 'S' && direcao != 'L' && direcao != 'O')
                posicaoValida = false;
            else
                posicaoValida = true;

            return posicaoValida;
        }

        public bool ComandoDeExploracaoValido()
        {
            char[] comandoMovimento = comandoExploracao.ToCharArray();
            bool comandoValido = false;

            for (int i = 0; i < comandoMovimento.Length; i++)
            {
                if (comandoMovimento[i] != 'E' && comandoMovimento[i] != 'D' && comandoMovimento[i] != 'M')
                {
                    comandoValido = false;
                    break;
                }
                else
                    comandoValido = true;
            }

            return comandoValido;
        }

        public bool TemVariosRobos()
        {
            if (quantidade > 1 && numero == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

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

        public void DefinirPosicaoFinal()
        {
            posicaoFinal = $"{x} {y} {direcao}";
        }
    }
}
