using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using BattleChess.Screens;

using BattleChess;
using BattleChess.GameObjects.Board;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BattleChess.Screens
{
    class MenuScreen : Screen
    {
        private Texture2D background;
        private Texture2D newGame;
        private Texture2D newGameClicked;
        private Texture2D players;
        private Texture2D playersClicked;
        private Texture2D exit;
        private Texture2D exitClicked;

        private Rectangle backgroundRectangle;
        private Rectangle newGameRectangle;
        private Rectangle playersRectangle;
        private Rectangle exitRectangle;

        private bool isExitClicked;

        public override void LoadContent()
        {
            base.LoadContent();
            //Load textures
            background = content.Load<Texture2D>("Sprites/Menu/MenuBackground");
            
            newGame = content.Load<Texture2D>("Sprites/Menu/NewGame");
            newGameClicked = content.Load<Texture2D>("Sprites/Menu/NewGameClicked");
            
            players = content.Load<Texture2D>("Sprites/Menu/Players");
            playersClicked = content.Load<Texture2D>("Sprites/Menu/PlayersClicked");

            exit = content.Load<Texture2D>("Sprites/Menu/Exit");
            exitClicked = content.Load<Texture2D>("Sprites/Menu/ExitClicked");

            isExitClicked = false;

            //Draw rectangles
            backgroundRectangle = new Rectangle(0, 0, background.Width, background.Height);
            newGameRectangle = new Rectangle(100, 200, newGame.Width, newGame.Height);
            playersRectangle = new Rectangle(100, 300, players.Width, players.Height);
            exitRectangle = new Rectangle(100, 400, exit.Width, exit.Height);
        }

        public override void Update(GameTime gameTime)
        {
            
            if (isExitClicked)
            {
                Thread.Sleep(1500);
                Environment.Exit(0);
            }

            MouseState mouse = Mouse.GetState();

            if (mouse.LeftButton == ButtonState.Pressed)
            {
                if (mouse.X > newGameRectangle.X && (mouse.X < newGameRectangle.X + newGameRectangle.Width) && mouse.Y > newGameRectangle.Y && (mouse.Y < newGameRectangle.Y + newGameRectangle.Height))
                {
                    newGame = newGameClicked;

                    ScreenManager.Instance.Engine = new Engine.Engine();
                    ScreenManager.Instance.ChangeScreens("GameScreen");
                }

                if (mouse.X > playersRectangle.X && (mouse.X < playersRectangle.X + playersRectangle.Width) && mouse.Y > playersRectangle.Y && (mouse.Y < playersRectangle.Y + playersRectangle.Height))
                {
                    players = playersClicked;
                }

                if (mouse.X > exitRectangle.X && (mouse.X < exitRectangle.X + exitRectangle.Width) && mouse.Y > exitRectangle.Y && (mouse.Y < exitRectangle.Y + exitRectangle.Height))
                {
                    exit = exitClicked;
                    isExitClicked = true;
                }
            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {

            spriteBatch.Begin();

            spriteBatch.Draw(background, backgroundRectangle, Color.White);
            spriteBatch.Draw(newGame, newGameRectangle, Color.White);
            spriteBatch.Draw(players, playersRectangle, Color.White);
            spriteBatch.Draw(exit, exitRectangle, Color.White);

            spriteBatch.End();
        }
    }
}
