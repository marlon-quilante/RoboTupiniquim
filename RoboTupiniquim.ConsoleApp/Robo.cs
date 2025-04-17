namespace RoboTupiniquim.ConsoleApp
{
    internal class Robo
    {
        public int xAtual = 0;
        public int yAtual = 0;
        public char direcaoAtual = new char();
        public string[] posicaoAtual = new string[4];
        public char comandoAtual = new char();
        public string posicaoFinal = "";
        public int quantidade = 0;

        public void DefinirQuantidade()
        {
            Console.Write("Escolha a quantidade de robôs que farão a exploração: ");
            quantidade = int.Parse(Console.ReadLine());
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
            if (direcaoAtual == 'N' && comandoAtual == 'E')
            {
                direcaoAtual = 'O';
            }
            else if (direcaoAtual == 'N' && comandoAtual == 'D')
            {
                direcaoAtual = 'L';
            }
            else if (direcaoAtual == 'S' && comandoAtual == 'E')
            {
                direcaoAtual = 'L';
            }
            else if (direcaoAtual == 'S' && comandoAtual == 'D')
            {
                direcaoAtual = 'O';
            }
            else if (direcaoAtual == 'O' && comandoAtual == 'E')
            {
                direcaoAtual = 'S';
            }
            else if (direcaoAtual == 'O' && comandoAtual == 'D')
            {
                direcaoAtual = 'N';
            }
            else if (direcaoAtual == 'L' && comandoAtual == 'E')
            {
                direcaoAtual = 'N';
            }
            else if (direcaoAtual == 'L' && comandoAtual == 'D')
            {
                direcaoAtual = 'S';
            }
        }

        public void Movimentar(int xMaximo, int yMaximo)
        {
            if (comandoAtual == 'M' && direcaoAtual == 'N' && yAtual < yMaximo)
            {
                yAtual += 1;
            }
            else if (comandoAtual == 'M' && direcaoAtual == 'S' && yAtual > 0)
            {
                yAtual -= 1;
            }
            else if (comandoAtual == 'M' && direcaoAtual == 'L' && xAtual < xMaximo)
            {
                xAtual += 1;
            }
            else if (comandoAtual == 'M' && direcaoAtual == 'O' && xAtual > 0)
            {
                xAtual -= 1;
            }
        }

        public void DefinirPosicaoFinal(int xMaximo, int yMaximo)
        {
            Console.Write("Digite o comando de movimentação do robô: ");
            string instrucaoMovimento = Console.ReadLine();

            char[] comandoMovimento = instrucaoMovimento.ToCharArray();

            for (int i = 0; i < comandoMovimento.Length; i++)
            {
                comandoAtual = comandoMovimento[i];

                DefinirDirecao();
                Movimentar(xMaximo, yMaximo);
            }

            posicaoFinal = $"{xAtual} {yAtual} {direcaoAtual}";
        }

        public void ApresentarPosicaoFinal(int numeroRobo)
        {
            Console.WriteLine();
            Console.WriteLine($"Posição final do robô {numeroRobo}: " + posicaoFinal);
            Console.WriteLine("\nPressione ENTER para continuar...");
            Console.ReadLine();
        }
    }
}
