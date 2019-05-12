using System;
using SplashKitSDK;

public class Player
{
    private Bitmap _frogBitmap = new Bitmap("frog", "frog.png");

    private int X;
    private int Y;

    private int _playerLives;

    public int Lives
    {
        get
        {
            return _playerLives;
        }
    }

    public bool Quit 
    { 
        get;
        private set;
    }



    public Player(Window gameWindow)
    {
        X = gameWindow.Width / 2 - _frogBitmap.Width / 2;
        Y = gameWindow.Height - _frogBitmap.Height * 2;
        _playerLives = 3;
        Quit = false;
    }

    public void Draw()
    {
        _frogBitmap.Draw(X, Y);

    }

    public void HandleInput()
    {
        const int SPEED = 40;


        if (SplashKit.KeyTyped(KeyCode.LeftKey))
        {
            X -= SPEED;
        }
        if (SplashKit.KeyTyped(KeyCode.RightKey))
        {
            X += SPEED;
        }
        if (SplashKit.KeyTyped(KeyCode.UpKey))
        {
            Y -= SPEED;
        }
        if (SplashKit.KeyTyped(KeyCode.DownKey))
        {
            Y += SPEED;
        }
        if (SplashKit.KeyDown(KeyCode.EscapeKey)
        )
        {
            Quit = true;
        }
    }

    public void StayOnWindow(Window gameWindow)
    {
        if (X < 0)
        {
            X = 0;
        }
        if (X + _frogBitmap.Width > gameWindow.Width)
        {
            X = gameWindow.Width - _frogBitmap.Width;
        }
        if (Y < 0)
        {
            Y = 0;
        }
        if (Y + _frogBitmap.Height > gameWindow.Height)
        {
            Y = gameWindow.Height - _frogBitmap.Height;
        }
    }
}