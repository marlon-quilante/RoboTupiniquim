namespace RoboTupiniquim.ConsoleApp
{
    internal class Local
    {
        public int xMaximo = 0;
        public int yMaximo = 0;
        public string[] areaMaxima = new string[2];

        public void DefinirAreaMaxima()
        {
            Console.Write("Defina a área máxima de exploração: ");
            areaMaxima = Console.ReadLine().Split(' ');

            xMaximo = int.Parse(areaMaxima[0]);
            yMaximo = int.Parse(areaMaxima[1]);
        }
    }
}
