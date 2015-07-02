using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

using BattleChess.GameObjects.Board;
using BattleChess.Interfaces;
using BattleChess.Screens;
using BattleChess.Enumerations;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

namespace BattleChess.Engine
{
    public class Engine
    {
        private Board board;
        private List<IPlayer> players;
        private Player currentPlayer;
        private bool currentPlayerHasMoved;
        private bool isWhite = true;
        private Position positionToClear;
        ButtonState previousButtonState = ButtonState.Released;

        public IFigure ClickedFigure { get; set; }
        public Rectangle ClickedFigureRectangle { get; private set; }
        public ContentManager Content { get; set; }



        public Engine()
        {

            this.Board = new Board();
            this.players = new List<IPlayer> 
            {
                new Player("Gosho", Enumerations.Color.White),
                new Player("Pesho", Enumerations.Color.Black)
            };
            currentPlayer = (Player)players[0];
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

        public void NextTurn()
        {
            UpdateGameState();

        }

        public void UpdateGameState()
        {
            KeyboardState keyboard = Keyboard.GetState();

            if (keyboard.IsKeyDown(Keys.Enter) && (ScreenManager.Instance.CurrentScreen is SplashScreen))
            {
                Thread.Sleep(300);
                ScreenManager.Instance.ChangeScreens("GameScreen");
            }

            if (keyboard.IsKeyDown(Keys.Escape))
            {
                if (ScreenManager.Instance.CurrentScreen is MenuScreen)
                {
                    Thread.Sleep(300);
                    ScreenManager.Instance.ChangeScreens("GameScreen");
                }

                else
                {
                    Thread.Sleep(300);
                    ScreenManager.Instance.ChangeScreens("MenuScreen");
                }
            }

            //Read mouse state and handle input
            MouseState mouse = Mouse.GetState();
            if (mouse.LeftButton == ButtonState.Pressed)
            {
                int x = mouse.X - GlobalConstants.BoardTopLeftX;
                int y = mouse.Y - GlobalConstants.BoardTopLeftY;

                Position squareClicked = GetCLickedSquare(x, y);

                if (Board.Squares[squareClicked] != null && ClickedFigure == null)
                {
                    if (Board.Squares[squareClicked].Color == currentPlayer.Color)
                    {
                        ClickedFigure = Board.Squares[squareClicked];
                        positionToClear = Board.Squares.Keys.FirstOrDefault(pos => pos.Equals(squareClicked));

                        //calculate valid moves
                        ClickedFigure.CalcLegalPositions(squareClicked, Board);
                    }

                    Board.Squares[squareClicked] = ClickedFigure;
                }


                if (ClickedFigure != null)
                {
                    if (Board.Squares[squareClicked] == null || Board.Squares[squareClicked].Color != currentPlayer.Color)
                    {
                        if (ClickedFigure.LegalPositions.Contains(squareClicked))
                        {

                            Board.Squares[squareClicked] = ClickedFigure;

                            ClickedFigure = null;
                            ClickedFigureRectangle = Rectangle.Empty;
                            Board.Squares[positionToClear] = null;
                            currentPlayerHasMoved = true;

                            Thread.Sleep(500);
                        }


                        if (currentPlayerHasMoved)
                        {
                            isWhite = !isWhite;
                            currentPlayerHasMoved = false;
                            currentPlayer = isWhite ? (Player)players[0] : (Player)players[1];
                        }

                        return;
                    }
                }

                previousButtonState = mouse.LeftButton;
            }

            ClickedFigureRectangle = ClickedFigure == null ? Rectangle.Empty : new Rectangle(mouse.X - 40, mouse.Y - 40, 80, 80);

            //this.Board.Squares[squareClicked] = null;
        }
    }
}
