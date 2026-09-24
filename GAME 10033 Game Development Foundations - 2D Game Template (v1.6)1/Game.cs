// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Genie in a bottle");
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(0, 0, 0);

          
            
            /// Setup the Lamp Color, size and outlien color
            Draw.SetFillColor(255, 255, 0);
            Draw.SetLineColor(255, 255, 0);
            Draw.SetLineSize(1);

            /// Triangles first
            Draw.Triangle(140, 300, 180, 300, 180, 320);
            Draw.Triangle(180, 340, 200, 340, 200, 360);
            Draw.Triangle(200, 380, 220, 360, 220, 380);
            Draw.Triangle(220, 300, 240, 280, 240, 300);
            Draw.Triangle(260, 280, 260, 300, 280, 300);
            Draw.Triangle(260, 360, 260, 380, 280, 380);
            Draw.Triangle(300, 340, 320, 340, 300, 360);
            Draw.Triangle(320, 300, 340, 300, 320, 320);
            
            /// Rectangles next
            Draw.Rectangle(180, 300, 140, 40);
            Draw.Rectangle(320, 280, 60, 20);
            Draw.Rectangle(360, 300, 20, 40);
            Draw.Rectangle(200, 340, 100, 20);
            Draw.Rectangle(220, 360, 40, 20);

            /// Squares finale
            Draw.Square(240, 280, 20);
            Draw.Square(340, 320, 20);


            



        }
    }

}
