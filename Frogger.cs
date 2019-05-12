using System;
using SplashKitSDK;

public class Frogger
{

    private Window _gameWindow;

    private Player _Player;

    public const int TILE_LENGHT = 40;

    public int number_of_width_intervals;
    public int number_of_height_intervals;

    public bool Quit
    {
        get
        {
            return _Player.Quit;
        }
    }

    public Frogger(Window gameWindow)
    {

        _gameWindow = gameWindow;
        _Player = new Player(_gameWindow);

        number_of_width_intervals = _gameWindow.Width / TILE_LENGHT;
        number_of_height_intervals = _gameWindow.Height / TILE_LENGHT;
    }

    public void Draw()
    {   
        DrawGameBoard();
        //drawGrid();
        _Player.Draw();
    }

    public void drawGrid()
    {
        int interval = TILE_LENGHT;

        for (int i = 0; i < number_of_width_intervals; i++)
        {
            SplashKit.DrawLine(Color.Red, interval, 0, interval, _gameWindow.Height);
            interval += TILE_LENGHT;
        }
        interval = TILE_LENGHT;
        for (int i = 0; i < number_of_height_intervals; i++)
        {
            SplashKit.DrawLine(Color.Red, 0, interval, _gameWindow.Width, interval);
            interval += TILE_LENGHT;
        }
    }

    public void DrawGameBoard()
    {
        //Score Zone
        SplashKit.FillRectangle(Color.Black, 0, _gameWindow.Height - TILE_LENGHT, _gameWindow.Width, TILE_LENGHT);
        //Starting Zone
        SplashKit.FillRectangle(Color.Purple, 0, _gameWindow.Height - TILE_LENGHT * 2, _gameWindow.Width, TILE_LENGHT);
        //Road
        SplashKit.FillRectangle(Color.Black, 0, TILE_LENGHT * 7, _gameWindow.Width, TILE_LENGHT * 4);
        //Second Safe Zone
        SplashKit.FillRectangle(Color.Purple, 0, TILE_LENGHT * 6, _gameWindow.Width, TILE_LENGHT);
        //Water
        SplashKit.FillRectangle(Color.Blue, 0,  TILE_LENGHT * 2, _gameWindow.Width, TILE_LENGHT * 4);
        //Sencond Last Strip
        int interval = 0;
        for (int i = 0; i < 6; i++)
        {
            SplashKit.FillRectangle(Color.Green, TILE_LENGHT * interval, TILE_LENGHT, TILE_LENGHT * 2, TILE_LENGHT);
            interval += 3;
        }
        //Water for the Lily Pads
        interval = 2;
        for (int i = 0; i < 5; i++)
        {
             SplashKit.FillRectangle(Color.Blue, TILE_LENGHT * interval, TILE_LENGHT, TILE_LENGHT, TILE_LENGHT);
             SplashKit.FillCircle(Color.Green, TILE_LENGHT * interval + 20, TILE_LENGHT + 20, 15);
             interval+= 3;
        }
       
        //Ending Strip
        SplashKit.FillRectangle(Color.Green, 0, 0, _gameWindow.Width, TILE_LENGHT);
    }


    public void HandleInput()
    {
        _Player.HandleInput();
        _Player.StayOnWindow(_gameWindow);
    }

    public void Update()
    {
        //Checking Collision
        //Updating Cars
        //Updating Logs
    }

}