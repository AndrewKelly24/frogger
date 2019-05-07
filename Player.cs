using System;
using SplashKitSDK;

public class Player
{
    private Bitmap _Player = new Bitmap("frog", "frog.png");

    private int X;
    private int Y;

    public Player(Window gameWindow)
    {
        X = 0 ;
        Y = 0;//gameWindow.Height - _Player.Height;
    }

    public void Draw()
    {
        _Player.Draw(X, Y);
        
        
    }
    
}