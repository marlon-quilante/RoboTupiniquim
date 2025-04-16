namespace RoboTupiniquim.ConsoleApp
{
    internal class Robo
    {
        public int xAtual = 0;
        public int yAtual = 0;
        public char direcaoAtual = new char();
        public string[] posicaoAtual = new string[4];

        public int xFinal = 0;
        public int yFinal = 0;
        public char direcaoFinal = new char();
        public string[] posicaoFinal = new string[4];

        public int quantidade = 2;

        public void DefinirQuantidade()
        {

        }

        public void DefinirPosicaoAtual()
        {
            Console.Write("Digite a posição atual do robô: ");
            string posicaoDigitada = Console.ReadLine();

            posicaoAtual = posicaoDigitada.Split(' ');

            xAtual = int.Parse(posicaoAtual[0]);
            yAtual = int.Parse(posicaoAtual[1]);
            direcaoAtual = char.Parse(posicaoAtual[2]);
        }

        public void DefinirDirecao()
        {
            string instrucaoMovimento = "DMEMM";

            char[] comandoMovimento = instrucaoMovimento.ToCharArray();

            for (int i = 0; i < comandoMovimento.Length; i++)
            {
                if (direcaoAtual == 'N' && comandoMovimento[i] == 'E')
                {
                    direcaoAtual = 'O';
                    break;
                }
                else if (direcaoAtual == 'N' && comandoMovimento[i] == 'D')
                {
                    direcaoAtual = 'L';
                    break;
                }
                else if (direcaoAtual == 'S' && comandoMovimento[i] == 'E')
                {
                    direcaoAtual = 'L';
                    break;
                }
                else if (direcaoAtual == 'S' && comandoMovimento[i] == 'D')
                {
                    direcaoAtual = 'O';
                    break;
                }
                else if (direcaoAtual == 'O' && comandoMovimento[i] == 'E')
                {
                    direcaoAtual = 'S';
                    break;
                }
                else if (direcaoAtual == 'O' && comandoMovimento[i] == 'D')
                {
                    direcaoAtual = 'N';
                    break;
                }
                else if (direcaoAtual == 'L' && comandoMovimento[i] == 'E')
                {
                    direcaoAtual = 'N';
                    break;
                }
                else if (direcaoAtual == 'L' && comandoMovimento[i] == 'D')
                {
                    direcaoAtual = 'S';
                    break;
                }
            }
        }

        public void Movimentar()
        {
            string instrucaoMovimento = "DMEMM";

            char[] comandoMovimento = instrucaoMovimento.ToCharArray();

            for (int i = 0; i < comandoMovimento.Length; i++)
            {
                if (comandoMovimento[i] == 'M' && direcaoAtual == 'N')
                {
                    yAtual += 1;
                    break;
                }
                else if (comandoMovimento[i] == 'M' && direcaoAtual == 'S')
                {
                    yAtual -= 1;
                    break;
                }
                else if (comandoMovimento[i] == 'M' && direcaoAtual == 'L')
                {
                    xAtual += 1;
                    break;
                }
                else if (comandoMovimento[i] == 'M' && direcaoAtual == 'O')
                {
                    xAtual -= 1;
                    break;
                }
            }
        }

        public void DefinirPosicaoFinal()
        {

        }
    }
}
