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
        private int index = 0;
        private Texture2D whiteKing;
        private Texture2D blackKing;

        private Rectangle drawRectangle;
        private Rectangle drawRectangle1;
        private Texture2D board;

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

            drawRectangle = new Rectangle(100, 100, whiteKing.Width, whiteKing.Height);
            drawRectangle1 = new Rectangle(200, 200, blackKing.Width, blackKing.Height);

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

            spriteBatch.Draw(board, new Rectangle(0, 0, board.Width, board.Height), Color.White);

            for (int i = 0; i < 8; i++)
            {
                spriteBatch.Draw(whiteKing, new Rectangle(rowIndex, colIndex, whiteKing.Width, whiteKing.Height), Color.Beige);
                rowIndex += 70;
            }

            colIndex += 70;
            rowIndex = 50;
            for (int i = 0; i < 8; i++)
            {
                spriteBatch.Draw(whiteKing, new Rectangle(rowIndex, colIndex, whiteKing.Width, whiteKing.Height), Color.Beige);
                rowIndex += 70;
            }




            spriteBatch.End();
        }
    }
}
