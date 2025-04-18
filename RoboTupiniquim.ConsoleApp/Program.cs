using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RoboTupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                CabecalhoInicial();
                                
                int quantidadeRobos = ObterQuantidadeRobos();

                for (int numeroRobo = 1; numeroRobo <= quantidadeRobos; numeroRobo++)
                {
                    Robo robo = new Robo();
                    robo.numero = numeroRobo;

                    Local local = new Local();
                    DefinirArea(local);

                    Console.Clear();
                    Console.Write("Digite a posição atual do robô: ");
                    string posicaoDigitada = Console.ReadLine();

                    robo.DefinirPosicaoAtual(posicaoDigitada);

                    Console.Write("Digite o comando de movimentação do robô: ");
                    string instrucaoMovimento = Console.ReadLine();

                    bool rotaValida = robo.Explorar(instrucaoMovimento, local);
                    if (rotaValida == false)
                        ApresentarMensagem(robo.mensagemErro);
                    else
                        ApresentarPosicaoFinal(robo);

                    if (quantidadeRobos > 1 && robo.numero == 1)
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

        public static void ApresentarPosicaoFinal(Robo robo)
        {
            Console.WriteLine();
            Console.WriteLine($"Posição final do robô {robo.numero}: " + robo.posicaoFinal);
        }

        private static void ApresentarMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
            Console.ReadLine();
            Console.Clear();
        }

        private static void DefinirArea(Local local)
        {
            Console.Write("Defina a área máxima de exploração: ");
            string areaMaxima = Console.ReadLine();

            local.DefinirAreaMaxima(areaMaxima);
        }

        public static int ObterQuantidadeRobos()
        {
            int quantidade = 0;

            Console.Write("Escolha a quantidade de robôs que farão a exploração: ");
            quantidade = int.Parse(Console.ReadLine());

            return quantidade;
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

        static void CabecalhoInicial()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Bem-vindo(a) à central de controle do Robô Tupiniquim!");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("\nPressione ENTER para continuar...");
            Console.ReadLine();
        }
    }
}
