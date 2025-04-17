namespace RoboTupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * plano cartesiano inicia em 0,0
             * 
             * primeiro input: tamanho do plano cartesiano. Ex: 5 5
             * segundo input: posição atual do robô. Ex: 1 2 N
             * terceiro input: movimentação do robô ---> E = 90º à esquerda; D = 90º à direita; M = Move
             * 
             * output: posição final do robô. Ex: 1 3 N
             */

            while (true)
            {
                Robo robo = new Robo();
                Local local = new Local();

                Console.Clear();
                robo.DefinirQuantidade();

                for (int numeroRobo = 1; numeroRobo <= robo.quantidade; numeroRobo++)
                {
                    Console.Clear();
                    Console.WriteLine($"Robô {numeroRobo}...\n");
                    local.DefinirAreaMaxima();
                    robo.DefinirPosicaoAtual();
                    robo.DefinirPosicaoFinal(local.xMaximo, local.yMaximo);
                    robo.ApresentarPosicaoFinal(numeroRobo);
                }

                if (!ContinuarExplorando())
                {
                    break;
                }
            }
        }

        static bool ContinuarExplorando()
        {
            Console.WriteLine("1- Continuar explorando");
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
    }
}
