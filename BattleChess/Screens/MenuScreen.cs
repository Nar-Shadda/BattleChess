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

        private Rectangle backgroundRectangle;
        private Rectangle newGameRectangle;


        public override void LoadContent()
        {
            base.LoadContent();

            background = content.Load<Texture2D>("Sprites/Menu/MenuBackground");
            newGame = content.Load<Texture2D>("Sprites/Menu/NewGame");
            newGameClicked = content.Load<Texture2D>("Sprites/Menu/NewGameClicked");

            backgroundRectangle = new Rectangle(0, 0, background.Width, background.Height);
            newGameRectangle = new Rectangle(100, 150, newGame.Width, newGame.Height);
        }

        public override void Update(GameTime gameTime)
        {
            MouseState mouse = Mouse.GetState();

            if (mouse.LeftButton == ButtonState.Pressed)
            {
                if (mouse.X > newGameRectangle.X && (mouse.X < newGameRectangle.X + newGameRectangle.Width) && mouse.Y > newGameRectangle.Y && (mouse.Y < newGameRectangle.Y + newGameRectangle.Height))
                {
                    newGame = newGameClicked;

                    ScreenManager.Instance.Engine = new Engine.Engine();
                    
                    ScreenManager.Instance.ChangeScreens("GameScreen");
                }
            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {

            spriteBatch.Begin();

            spriteBatch.Draw(background, backgroundRectangle, Color.White);
            spriteBatch.Draw(newGame, newGameRectangle, Color.White);

            spriteBatch.End();
        }
    }
}
