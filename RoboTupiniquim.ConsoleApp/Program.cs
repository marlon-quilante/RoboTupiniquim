namespace RoboTupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                CabecalhoInicial();

                Robo robo = new Robo();
                Local local = new Local();

                Console.Clear();
                robo.DefinirQuantidade();

                for (int numeroRobo = 1; numeroRobo <= robo.quantidade; numeroRobo++)
                {
                    robo = new Robo(robo.quantidade);
                    local = new Local();

                    robo.roboAtual = numeroRobo;
                    Console.Clear();
                    local.DefinirAreaMaxima(robo);
                    robo.DefinirPosicaoAtual(local.xMaximo, local.yMaximo);
                    robo.DefinirPosicaoFinal(local.xMaximo, local.yMaximo);
                    robo.ApresentarPosicaoFinal(robo.roboAtual);

                    if (robo.quantidade > 1 && robo.roboAtual == 1)
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
