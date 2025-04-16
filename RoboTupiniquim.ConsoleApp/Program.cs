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
                Robo robo1 = new Robo();

                robo1.DefinirPosicaoAtual();
            }

        }
    }
}
