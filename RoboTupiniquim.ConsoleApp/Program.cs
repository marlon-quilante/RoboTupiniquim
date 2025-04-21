namespace RoboTupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                CabecalhoInicial();

                int quantidadeRobos = DefinirQuantidadeRobos();

                for (int numeroRobo = 1; numeroRobo <= quantidadeRobos; numeroRobo++)
                {
                    Robo robo = new Robo();
                    Local local = new Local();

                    robo.numero = numeroRobo;
                    robo.quantidade = quantidadeRobos;
                    LimparTela();

                    while (true)
                    {
                        local.areaMaxima = DefinirAreaDeExploracao(robo);

                        if (local.LimiteDaAreaDefinido())
                            break;
                        else
                            ApresentarMensagem("\nLimite da área de exploração inválida! Pressione ENTER para inserir a área novamente...");
                    }

                    while (true)
                    {
                        robo.posicao = DefinirPosicaoInicial(robo);

                        if (robo.PosicaoInicialDefinida() && robo.PosicaoInicialValida(local))
                            break;
                        else
                            ApresentarMensagem("\nPosição inicial do robô inválida! Pressione ENTER para inserir a posição novamente...");
                    }

                    while (true)
                    {
                        robo.comandoExploracao = DefinirComandoDeExploracao(robo, local);

                        if (robo.ComandoDeExploracaoValido())
                        {
                            char[] comandoMovimento = robo.comandoExploracao.ToCharArray();

                            for (int i = 0; i < comandoMovimento.Length; i++)
                            {
                                robo.comandoAtual = comandoMovimento[i];

                                robo.GirarParaDireita();
                                robo.GirarParaEsquerda();
                                robo.Mover(local);
                                robo.DefinirPosicaoFinal();
                                ApresentarAreaDeExploracao(local, robo);
                                Thread.Sleep(1000);
                            }

                            break;
                        }
                        else
                            ApresentarMensagem("\nComando de exploração inválido! Pressione ENTER para inserir o comando novamente...");
                    }

                    ApresentarPosicaoFinal(robo, local);

                    if (robo.TemVariosRobos())
                    {
                        Console.WriteLine("\nPressione ENTER para continuar...");
                        Console.ReadLine();
                    }
                }

                if (!ContinuarExplorando())
                {
                    break;
                }
            }
        }

        static void LimparTela()
        {
            Console.Clear();
        }

        static void CabecalhoInicial()
        {
            LimparTela();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Bem-vindo(a) à central de controle do Robô Tupiniquim!");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("\nPressione ENTER para continuar...");
            Console.ReadLine();
            LimparTela();
        }

        static int DefinirQuantidadeRobos()
        {
            try
            {
                Console.Write("Escolha a quantidade de robôs que farão a exploração: ");
                return int.Parse(Console.ReadLine());
            }
            catch
            {
                ApresentarMensagem("\nOcorreu um erro na definição da quantidade de robôs! Pressione ENTER para inserir a quantidade novamente...");
                return DefinirQuantidadeRobos();
            }
        }

        static void ApresentarNumeroRobo(Robo robo)
        {
            LimparTela();
            Console.WriteLine($"Robô {robo.numero}...\n");
        }

        static string DefinirAreaDeExploracao(Robo robo)
        {
            ApresentarNumeroRobo(robo);
            Console.Write("Defina a área máxima de exploração: ");
            return Console.ReadLine();
        }

        static string DefinirPosicaoInicial(Robo robo)
        {
            ApresentarNumeroRobo(robo);
            Console.Write("Digite a posição atual do robô: ");
            return Console.ReadLine();
        }

        static void ApresentarAreaDeExploracao(Local local, Robo robo)
        {
            LimparTela();
            ApresentarNumeroRobo(robo);
            local.MontarAreaDeExploracao(robo);
            Console.WriteLine("Área de Exploração:\n");

            for (int linha = local.yMaximo; linha >= 0; linha--)
            {
                for (int coluna = 0; coluna <= local.xMaximo; coluna++)
                {
                    if (linha == robo.y && coluna == robo.x)
                    {
                        var aux = Console.ForegroundColor;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(local.desenhoArea[coluna, linha]);
                        Console.ForegroundColor = aux;
                    }
                    else
                        Console.Write(local.desenhoArea[coluna, linha]);
                }
                Console.WriteLine();
            }
        }

        static string DefinirComandoDeExploracao(Robo robo, Local local)
        {
            ApresentarAreaDeExploracao(local, robo);
            Console.Write("\nDigite o comando de movimentação do robô: ");
            return Console.ReadLine();
        }

        static void ApresentarPosicaoFinal(Robo robo, Local local)
        {
            ApresentarAreaDeExploracao(local, robo);
            Console.WriteLine($"\nPosição final do robô {robo.numero}: " + robo.posicaoFinal);
        }

        static bool ContinuarExplorando()
        {
            Console.WriteLine("\n1- Continuar explorando");
            Console.WriteLine("2- Sair\n");

            string opcaoEscolhida = Console.ReadLine();

            if (opcaoEscolhida == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void ApresentarMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
            Console.ReadLine();
            LimparTela();
        }
    }
}
