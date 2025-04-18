namespace RoboTupiniquim.ConsoleApp;

public class Robo
{
    public int numero = 0;

    public int posicaoX = 0;
    public int posicaoY = 0;
    public char direcao;

    public string mensagemErro = "";

    public char comandoAtual = new char();
    public string posicaoFinal = "";

    public void DefinirPosicaoAtual(string posicaoDigitada)
    {
        string[] posicaoAtual = posicaoDigitada.Split(' ');

        posicaoX = int.Parse(posicaoAtual[0]);
        posicaoY = int.Parse(posicaoAtual[1]);
        direcao = char.Parse(posicaoAtual[2]);   
    }    

    public bool Explorar(string instrucaoMovimento, Local area)
    {
        char[] comandoMovimento = instrucaoMovimento.ToCharArray();

        if (ComandoInvalido(comandoMovimento))
        {
            mensagemErro = "Comando de movimentação inválido! Pressione ENTER para digitar o comando de movimentação novamente...";
            return false;
        }

        for (int i = 0; i < comandoMovimento.Length; i++)
        {
            comandoAtual = comandoMovimento[i];

            if (comandoAtual == 'M')
                Mover();

            else if (comandoAtual == 'E')
                VirarEsquerda();

            else if (comandoAtual == 'D')
                VirarDireita();           
        }

        Robo roboAtual = this;

        if (area.PosicaoValida(roboAtual))
        {
            posicaoFinal = $"{posicaoX} {posicaoY} {direcao}";
            return true;
        }
        else
        {
            mensagemErro = "rota inválida";
            return false;
        }
    }

    private void VirarDireita()
    {
        if (direcao == 'N')
            direcao = 'L';

        else if (direcao == 'S')
            direcao = 'O';

        else if (direcao == 'L')
            direcao = 'S';

        else if (direcao == 'O')
            direcao = 'N';
    }

    private void VirarEsquerda()
    {
        if (direcao == 'N')
            direcao = 'O';

        else if (direcao == 'S')
            direcao = 'L';

        else if (direcao == 'L')
            direcao = 'N';

        else if (direcao == 'O')
            direcao = 'S';
    }

    private void Mover()
    {
        if (direcao == 'N')
            posicaoY += 1;

        else if (direcao == 'S')
            posicaoY -= 1;

        else if (direcao == 'L')
            posicaoX += 1;

        else if (direcao == 'O')
            posicaoX -= 1;
    }

    private bool ComandoInvalido(char[] comandoMovimento)
    {
        bool comandoInvalido = false;
        for (int i = 0; i < comandoMovimento.Length; i++)
        {
            if (comandoMovimento[i] != 'E' && comandoMovimento[i] != 'D' && comandoMovimento[i] != 'M')
            {
                comandoInvalido = true;
                break;
            }
        }

        return comandoInvalido;
    }


}
