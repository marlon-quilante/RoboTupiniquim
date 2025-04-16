namespace RoboTupiniquim.ConsoleApp
{
    internal class Robo
    {
        public int xAtual = 0;
        public int yAtual = 0;
        public char direcaoAtual = new char();

        public int xFinal = 0;
        public int yFinal = 0;
        public string direcaoFinal = "";

        public int quantidade = 2;

        public void DefinirQuantidade()
        {

        }

        public void DefinirPosicaoAtual()
        {
            string posicaoAtual = "1 2 N";
            xAtual = Convert.ToInt32(posicaoAtual[0]);
            yAtual = Convert.ToInt32(posicaoAtual[2]);
            direcaoAtual = posicaoAtual[5];
        }

        public void DefinirPosicaoFinal()
        {

        }

        public void Movimentar()
        {
        }

        public void DefinirDirecaoAtual()
        {
            string instrucaoMovimento = "DMEMM";

            char[] comandoMovimento = instrucaoMovimento.ToCharArray();

            for (int i = 0; i < comandoMovimento.Length; i++)
            {
                if (direcaoAtual == 'N' && comandoMovimento[i] == 'E')
                {
                    direcaoAtual = 'O';
                }
                else if (direcaoAtual == 'N' && comandoMovimento[i] == 'D')
                {
                    direcaoAtual = 'L';
                }
                else if (direcaoAtual == 'S' && comandoMovimento[i] == 'E')
                {
                    direcaoAtual = 'L';
                }
                else if (direcaoAtual == 'S' && comandoMovimento[i] == 'D')
                {
                    direcaoAtual = 'O';
                }
                else if (direcaoAtual == 'O' && comandoMovimento[i] == 'E')
                {
                    direcaoAtual = 'S';
                }
                else if (direcaoAtual == 'O' && comandoMovimento[i] == 'D')
                {
                    direcaoAtual = 'N';
                }
                else if (direcaoAtual == 'L' && comandoMovimento[i] == 'E')
                {
                    direcaoAtual = 'N';
                }
                else if (direcaoAtual == 'L' && comandoMovimento[i] == 'D')
                {
                    direcaoAtual = 'S';
                }
            }
        }
    }
}
