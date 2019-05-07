using System;
using SplashKitSDK;

public class Frogger
{

    private Window _gameWindow;

    private Player _Player;

    public Frogger(Window gameWindow)
    {

        _gameWindow = gameWindow;
        _Player = new Player(_gameWindow);
    }

    public void Draw()
    {
        _Player.Draw();
        drawGrid();
    }

    public void drawGrid()
    {
        int interval = 40;
        for (int i = 0; i < 8; i++)
        {
            SplashKit.DrawLine(Color.Red, interval, 0, interval, _gameWindow.Height);
            interval += 40;
        }
        interval = 40;
         for (int i = 0; i < 12; i++)
        {
            SplashKit.DrawLine(Color.Red, 0, interval, _gameWindow.Width, interval);
            interval += 40;
        }
    }


}