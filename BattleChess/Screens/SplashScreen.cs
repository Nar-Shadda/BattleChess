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
        private Texture2D draw;
        private Texture2D whiteKing;
        private Texture2D blackKing;

        private Texture2D board;
        private Texture2D border;

        private List<Texture2D> drawables;

        public SplashScreen(Game engine)
            : base(engine)
        {

        }

        public override void LoadContent()
        {
            base.LoadContent();

            whiteKing = content.Load<Texture2D>("Sprites/Figures/KingWhite");
            blackKing = content.Load<Texture2D>("Sprites/Figures/KingWhite");
            board = content.Load<Texture2D>("Sprites/Boards/board0");
            border = content.Load<Texture2D>("Sprites/Borders/border0");

            drawables = new List<Texture2D> { whiteKing, blackKing };

        }

        public override void Update(GameTime gameTime)
        {
            //TODO: update drawables list from engine
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            int rowIndex = 50;
            int colIndex = 50;

            spriteBatch.Begin();
            
            spriteBatch.Draw(border, new Rectangle(0,0, border.Width,border.Height), Color.White);
            spriteBatch.Draw(board, new Rectangle(GlobalConstants.BoardTopLeftX, GlobalConstants.BoardTopLeftY, board.Width, board.Height), Color.White);

            for (int i = 0; i < 8; i++)
            {
                spriteBatch.Draw(whiteKing, new Rectangle(GlobalConstants.BoardTopLeftX+i*80, GlobalConstants.BoardTopLeftY, whiteKing.Width, whiteKing.Height), Color.BurlyWood);
                rowIndex += 70;
            }

            




            spriteBatch.End();
        }
    }
}
