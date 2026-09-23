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
            Window.SetSize(200, 200);
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
            Draw.Triangle(70, 150, 90, 150, 90, 160);
            Draw.Triangle(90, 170, 100, 170, 100, 180);
            Draw.Triangle(100, 190, 110, 180, 110, 190);
            Draw.Triangle(110, 150, 120, 140, 120, 150);
            Draw.Triangle(130, 140, 130, 150, 140, 150);
            Draw.Triangle(130, 180, 130, 190, 140, 190);
            Draw.Triangle(150, 180, 150, 170, 160, 170);
            Draw.Triangle(160, 150, 160, 160, 170, 150);
            
            /// Rectangles next
            Draw.Rectangle(90, 150, 70, 20);
            Draw.Rectangle(160, 140, 30, 10);
            Draw.Rectangle(180, 150, 10, 20);
            Draw.Rectangle(100, 170, 50, 10);
            Draw.Rectangle(110, 180, 20, 10);

            /// Squares finale
            Draw.Square(120, 140, 10);
            Draw.Square(170, 160, 10);


            



        }
    }

}
