using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BattleChess.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BattleChess.Screens
{
    class GameScreen : Screen
    {
        private Texture2D board;
        private Texture2D border;
        private Texture2D background;
        private Texture2D clickedFigure;
        private Texture2D player1;
        private Texture2D player2;

        private Dictionary<IFigure, Texture2D> textures;

        public override void LoadContent()
        {
            content = new ContentManager(
                ScreenManager.Instance.Content.ServiceProvider, "Content");

            textures = new Dictionary<IFigure, Texture2D>();

            board = content.Load<Texture2D>("Sprites/Boards/board0");
            border = content.Load<Texture2D>("Sprites/Borders/border0");
            background = content.Load<Texture2D>("Sprites/Backgrounds/background0");
            
            player1 = content.Load<Texture2D>("Sprites/Players/pesho");
            player2 = content.Load<Texture2D>("Sprites/Players/gosho");

            foreach (var fig in ScreenManager.Instance.Engine.Board.Squares.Values)
            {
                if (fig != null)
                {
                    Texture2D figure = content.Load<Texture2D>(fig.ImagePath);
                    textures.Add(fig, figure);
                }
            }

        }

        public override void UnloadContent()
        {
            content.Unload();
        }

        public override void Update(GameTime gameTime)
        {
            //TODO: get list from engine
            if (ScreenManager.Instance.Engine.ClickedFigure != null)
            {
                clickedFigure = content.Load<Texture2D>(ScreenManager.Instance.Engine.ClickedFigure.ImagePath);
            }

        }


        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            //draw background
            spriteBatch.Draw(background, new Rectangle(0, 0, background.Width, background.Height), Microsoft.Xna.Framework.Color.White);

            //draw border
            spriteBatch.Draw(border, new Rectangle(0, 0, border.Width, border.Height), Microsoft.Xna.Framework.Color.White);

            //draw board
            spriteBatch.Draw(board, new Rectangle(GlobalConstants.BoardTopLeftX, GlobalConstants.BoardTopLeftY, board.Width, board.Height), Microsoft.Xna.Framework.Color.White);

            //draw figures
            foreach (var square in ScreenManager.Instance.Engine.Board.Squares.Keys)
            {

                if (ScreenManager.Instance.Engine.Board.Squares[square] != null)
                {
                    var currentFigure = ScreenManager.Instance.Engine.Board.Squares[square];

                    int x = ('8' - square.Row) * textures[currentFigure].Height + GlobalConstants.BoardTopLeftX;
                    int y = (square.Col - 'a') * textures[currentFigure].Width + GlobalConstants.BoardTopLeftY;

                    spriteBatch.Draw(textures[currentFigure], new Rectangle(y, x, textures[currentFigure].Width, textures[currentFigure].Width), Microsoft.Xna.Framework.Color.White);
                }
            }

            //draw players
            spriteBatch.Draw(player1, new Rectangle(850, 100, player1.Width, player1.Height), Color.White);
            spriteBatch.Draw(player2, new Rectangle(850, 400, player2.Width, player2.Height), Color.White);

            //draw clicked figure
            if (clickedFigure != null)
            {
                spriteBatch.Draw(clickedFigure, ScreenManager.Instance.Engine.ClickedFigureRectangle, Microsoft.Xna.Framework.Color.White);
            }

            spriteBatch.End();
        }
    }
}
