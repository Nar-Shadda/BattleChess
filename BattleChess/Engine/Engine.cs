using BattleChess.GameObjects.Board;
using BattleChess.Initialize;
using BattleChess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Color = BattleChess.Enumerations.Color;

namespace BattleChess.Engine
{
    public class Engine
    {
        private Board board;
        private List<IPlayer> players;

        public IFigure ClickedFigure { get; set; }
        public Rectangle ClickedFigureRectangle { get; private set; }
        public ContentManager Content { get; set; }

        public Engine()
        {

            this.Board = new Board();
            this.players = new List<IPlayer> 
            {
                new Player("Gosho", Color.White),
                new Player("Pesho", Color.Black)
            };


        }


        public IEnumerable<IPlayer> Players
        {
            get
            {
                return new List<IPlayer>(this.players);
            }
        }

        public Board Board
        {
            get { return this.board; }
            set { this.board = value; }
        }

        public Position GetCLickedSquare(int x, int y)
        {
            int col = (int)Math.Ceiling(x / 80.0);
            int row = (int)Math.Ceiling(y / 80.0);
            return new Position((char)(col + 'a' - 1), (char)('9' - row));

        }

        public void UpdateGameState()
        {
            KeyboardState keyboard = Keyboard.GetState();

            if (keyboard.IsKeyDown(Keys.Enter))
            {
                ScreenManager.Instance.ChangeScreens("GameScreen");
            }

            if (keyboard.IsKeyDown(Keys.Escape))
            {
                ScreenManager.Instance.ChangeScreens("MenuScreen");
            }
            //if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            // Exit();

            // TODO: Add your update logic here

            MouseState mouse = Mouse.GetState();
            if (mouse.LeftButton == ButtonState.Pressed)
            {
                int x = mouse.X - GlobalConstants.BoardTopLeftX;
                int y = mouse.Y - GlobalConstants.BoardTopLeftY;

                Position squareClicked = GetCLickedSquare(x, y);

                if (Board.Squares.ContainsKey(squareClicked) && Board.Squares[squareClicked] != null)
                {

                    ClickedFigure = Board.Squares[squareClicked];
                    ClickedFigureRectangle = new Rectangle(mouse.X, mouse.Y, 80, 80);
                    //engine.Board.Squares[squareClicked] = null;
                }
            }
        }
    }
}
