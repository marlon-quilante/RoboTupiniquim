namespace RoboTupiniquim.ConsoleApp;

public class Local
{
    public int xMaximo = 0;
    public int yMaximo = 0;

    public void DefinirAreaMaxima(string area) // 5 5 
    {
        string[] areaMaxima = area.Split(' ');
        xMaximo = int.Parse(areaMaxima[0]);
        yMaximo = int.Parse(areaMaxima[1]);
    }

    public bool PosicaoValida(Robo robo)
    {
        if ((robo.posicaoX > xMaximo || robo.posicaoX < 0) || (robo.posicaoY > yMaximo || robo.posicaoY < 0))        
            return false;

        return true;
    }
}
