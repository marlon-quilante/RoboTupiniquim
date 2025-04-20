namespace RoboTupiniquim.ConsoleApp
{
    internal class Local
    {
        public int xMaximo = 0;
        public int yMaximo = 0;
        public string areaMaxima = "";

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

        public bool PosicaoInicialDefinida(Robo robo)
        {
            try
            {
                string[] posicaoAtual = robo.posicao.Split(' ');

                robo.x = int.Parse(posicaoAtual[0]);
                robo.y = int.Parse(posicaoAtual[1]);
                robo.direcao = char.Parse(posicaoAtual[2]);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool PosicaoInicialValida(Robo robo)
        {
            bool posicaoValida = false;

            if (robo.x > xMaximo || robo.x < 0)
                posicaoValida = false;
            else if (robo.y > yMaximo || robo.y < 0)
                posicaoValida = false;
            else if (robo.direcao != 'N' && robo.direcao != 'S' && robo.direcao != 'L' && robo.direcao != 'O')
                posicaoValida = false;
            else
                posicaoValida = true;

            return posicaoValida;
        }
    }
}
