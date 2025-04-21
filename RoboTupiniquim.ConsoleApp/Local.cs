namespace RoboTupiniquim.ConsoleApp
{
    internal class Local
    {
        public int xMaximo = 0;
        public int yMaximo = 0;
        public string areaMaxima = "";
        public string[,] desenhoArea = new string[0,0];

        public bool LimiteDaAreaDefinido()
        {
            string[] vetorAreaMaxima = areaMaxima.Split(' ');

            try
            {
                xMaximo = int.Parse(vetorAreaMaxima[0]);
                yMaximo = int.Parse(vetorAreaMaxima[1]);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void MontarAreaDeExploracao(Robo robo)
        {
            desenhoArea = new string[xMaximo+1, yMaximo+1];

            for (int linha = yMaximo; linha >= 0; linha--)
            {
                for (int coluna = 0; coluna <= xMaximo; coluna++)
                {
                    if (linha == robo.y && coluna == robo.x)
                    {
                        desenhoArea[coluna, linha] = robo.direcao + " ";
                    }
                    else
                    {
                        desenhoArea[coluna, linha] = "x ";
                    }
                }
            }
        }
    }
}
