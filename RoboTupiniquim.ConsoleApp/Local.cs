namespace RoboTupiniquim.ConsoleApp
{
    internal class Local
    {
        public int xMaximo = 0;
        public int yMaximo = 0;
        public string[] areaMaxima = new string[2];

        public void DefinirAreaMaxima(Robo robo)
        {
            try
            {
                Console.Clear();
                Console.WriteLine($"Robô {robo.roboAtual}...\n");
                Console.Write("Defina a área máxima de exploração: ");
                areaMaxima = Console.ReadLine().Split(' ');

                xMaximo = int.Parse(areaMaxima[0]);
                yMaximo = int.Parse(areaMaxima[1]);
            }
            catch
            {
                Console.WriteLine("\nOcorreu um erro na definição da área de exploração! Pressione ENTER para inserir a área novamente...");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"Robô {robo.roboAtual}...\n");
                DefinirAreaMaxima(robo);
            }
        }
    }
}
