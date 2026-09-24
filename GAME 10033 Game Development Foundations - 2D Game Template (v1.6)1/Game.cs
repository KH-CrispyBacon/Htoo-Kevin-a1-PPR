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
            Window.SetTitle("Genie in a bottle!");
            Window.SetSize(400, 400);

    
               
           
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(255);




            /// Setting up sand and sky background color

         
            Draw.SetFillColor(210, 180, 140);
            Draw.SetLineColor(0);
            Draw.SetLineSize(1);
            Draw.Rectangle(0, 240, 400, 400);

            Draw.SetFillColor(135, 206, 235);
            Draw.SetLineColor(0);
            Draw.SetLineSize(1);
            Draw.Rectangle(0, 0, 400, 240);

            /// Setup the Lamp Color, size and outline color
            Draw.SetFillColor(255, 255, 0);
            Draw.SetLineColor(0, 0, 0);
            Draw.SetLineSize(1);



            /// Making the shapes to design the lamp
            
        
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

            /// making user input where if the space bar is held down than the genie will appear and if the space bar is let go the genie will disappear
            /// 
            /// making sure the space is held down or not
            if (Input. IsKeyboardKeyDown(KeyboardKey.Space) == true)
            {
                /// creating genie
                Draw.SetFillColor(25, 189, 255);
                Draw.SetLineColor(0, 0, 0);
                Draw.SetLineSize(1);

                ///Creating triangles first

                Draw.Triangle(100, 280, 120, 280, 120, 300);
                Draw.Triangle(120, 260, 140, 260, 120, 280);
                Draw.Triangle(180, 240, 200, 240, 180, 260);
                Draw.Triangle(220, 220, 240, 220, 220, 240);
                Draw.Triangle(240, 200, 280, 200, 240, 220);
                Draw.Triangle(220, 20, 240, 40, 220, 40);

                /// Rectangles next

                Draw.Rectangle(120, 240, 60, 20);
                Draw.Rectangle(180, 220, 40, 20);
                Draw.Rectangle(180, 200, 60, 20);
                Draw.Rectangle(180, 100, 100, 100);
                Draw.Rectangle(200, 60, 60, 40);
                Draw.Rectangle(140, 100, 20, 60);
                Draw.Rectangle(300, 100, 20, 60);

                /// Squares finale

                Draw.Square(100, 260, 20);
                Draw.Square(160, 100, 20);
                Draw.Square(280, 100, 20);
                Draw.Square(200, 20, 20);
                Draw.Square(220, 40, 20);

                /// Making eyes

                Draw.SetFillColor(0);

                Draw.Circle(220, 80, 5);
                Draw.Circle(240, 80, 5);

            }
          

            
          

       


            



        }
    }

}
