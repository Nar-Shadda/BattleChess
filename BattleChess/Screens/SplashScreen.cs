using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BattleChess.Screens;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BattleChess.Screens
{
    class SplashScreen : Screen
    {
        private Texture2D currentFigure;
        private Rectangle drawRectangle;

        public SplashScreen(Game engine) : base(engine)
        {

        }

        public override void LoadContent()
        {
            base.LoadContent();
            
            currentFigure = content.Load<Texture2D>("Sprites/Figures/KingWhite");
            drawRectangle = new Rectangle(100, 100, currentFigure.Width, currentFigure.Height);

        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            
           
            spriteBatch.Begin();
           
            spriteBatch.Draw(currentFigure,drawRectangle, Color.White);

            spriteBatch.End();
        }
    }
}
