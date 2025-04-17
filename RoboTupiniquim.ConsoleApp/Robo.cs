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
        public int roboAtual = 0;

        public Robo()
        {
        }

        public Robo(int quantidade)
        {
            this.quantidade = quantidade;
        }

        public void DefinirQuantidade()
        {
            try
            {
                Console.Write("Escolha a quantidade de robôs que farão a exploração: ");
                quantidade = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("\nOcorreu um erro na definição da quantidade de robôs! Pressione ENTER para inserir a quantidade novamente...");
                Console.ReadLine();
                Console.Clear();
                DefinirQuantidade();
            }
        }

        public void DefinirPosicaoAtual(int xMaximo, int yMaximo)
        {
            try
            {
                Console.Clear();
                Console.WriteLine($"Robô {roboAtual}...\n");
                Console.Write("Digite a posição atual do robô: ");
                string posicaoDigitada = Console.ReadLine();

                posicaoAtual = posicaoDigitada.Split(' ');

                if (int.Parse(posicaoAtual[0]) > xMaximo || int.Parse(posicaoAtual[0]) < 0)
                {
                    Console.WriteLine("\nCoordenada x do robô está fora dos limites estabelecidos! Pressione ENTER para inserir a posição novamente...");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine($"Robô {roboAtual}...\n");
                    DefinirPosicaoAtual(xMaximo, yMaximo);
                }

                if (int.Parse(posicaoAtual[1]) > yMaximo || int.Parse(posicaoAtual[1]) < 0)
                {
                    Console.WriteLine("\nCoordenada y do robô está fora dos limites estabelecidos! Pressione ENTER para inserir a posição novamente...");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine($"Robô {roboAtual}...\n");
                    DefinirPosicaoAtual(xMaximo, yMaximo);
                }

                if (posicaoAtual[2] != "N" && posicaoAtual[2] != "S" && posicaoAtual[2] != "L" && posicaoAtual[2] != "O")
                {
                    Console.WriteLine("\nDireção do robô é inválida! Pressione ENTER para inserir a posição novamente...");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine($"Robô {roboAtual}...\n");
                    DefinirPosicaoAtual(xMaximo, yMaximo);
                }

                xAtual = int.Parse(posicaoAtual[0]);
                yAtual = int.Parse(posicaoAtual[1]);
                direcaoAtual = char.Parse(posicaoAtual[2]);
            }
            catch
            {
                Console.WriteLine("\nOcorreu um erro na definição da posição atual do robô! Pressione ENTER para inserir a posição novamente...");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"Robô {roboAtual}...\n");
                DefinirPosicaoAtual(xMaximo, yMaximo);
            }
        }

        public void DefinirDirecao()
        {
            if (direcaoAtual == 'N' && comandoAtual == 'E')
                direcaoAtual = 'O';
            else if (direcaoAtual == 'N' && comandoAtual == 'D')
                direcaoAtual = 'L';
            else if (direcaoAtual == 'S' && comandoAtual == 'E')
                direcaoAtual = 'L';
            else if (direcaoAtual == 'S' && comandoAtual == 'D')
                direcaoAtual = 'O';
            else if (direcaoAtual == 'O' && comandoAtual == 'E')
                direcaoAtual = 'S';
            else if (direcaoAtual == 'O' && comandoAtual == 'D')
                direcaoAtual = 'N';
            else if (direcaoAtual == 'L' && comandoAtual == 'E')
                direcaoAtual = 'N';
            else if (direcaoAtual == 'L' && comandoAtual == 'D')
                direcaoAtual = 'S';
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
            try
            {
                Console.Clear();
                Console.WriteLine($"Robô {roboAtual}...\n");
                Console.Write("Digite o comando de movimentação do robô: ");
                string instrucaoMovimento = Console.ReadLine();

                char[] comandoMovimento = instrucaoMovimento.ToCharArray();

                for (int i = 0; i < comandoMovimento.Length; i++)
                {
                    if (comandoMovimento[i] != 'E' && comandoMovimento[i] != 'D' && comandoMovimento[i] != 'M')
                    {
                        Console.WriteLine("\nComando de movimentação inválido! Pressione ENTER para digitar o comando de movimentação novamente...");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine($"Robô {roboAtual}...\n");
                        DefinirPosicaoFinal(xMaximo, yMaximo);
                        return;
                    }

                    comandoAtual = comandoMovimento[i];

                    DefinirDirecao();
                    Movimentar(xMaximo, yMaximo);
                }

                posicaoFinal = $"{xAtual} {yAtual} {direcaoAtual}";
            }
            catch
            {
                Console.WriteLine("\nOcorreu um erro na definição da posição final do robô! Pressione ENTER para digitar o comando de movimentação novamente...");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"Robô {roboAtual}...\n");
                DefinirPosicaoFinal(xMaximo, yMaximo);
            }
        }

        public void ApresentarPosicaoFinal(int numeroRobo)
        {
            Console.WriteLine();
            Console.WriteLine($"Posição final do robô {numeroRobo}: " + posicaoFinal);
        }
    }
}
