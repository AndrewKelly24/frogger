using System;
using SplashKitSDK;

public class Program
{
    public static void Main()
    {   

        // Bitmap frog = new Bitmap("frog", "frog.png");

        // Console.WriteLine(Convert.ToString(frog.Width));
        // Console.WriteLine(Convert.ToString(frog.Height));

             
        Bitmap background = new Bitmap("background", "frogger_background.png");
        //Background Width is 320 and Height is 480 Px
        //Make game width 8 tiles wide and heiight 12 tiles long
        //Each tile is 40 px in lenght and width
        
        Window gameWindow = new Window("Frogger", background.Width, background.Height);
        Frogger frogger = new Frogger(gameWindow);

        while(!SplashKit.QuitRequested())
        {            
            SplashKit.ProcessEvents();            
            //Draws the game background to the screen
            background.Draw(0,0);

            //Draw the game onto the background
            frogger.Draw();
            SplashKit.RefreshScreen(60);
        }

        

    }
}
