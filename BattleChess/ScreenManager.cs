using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Text;

using BattleChess.Screens;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BattleChess
{
    class ScreenManager
    {
        private static ScreenManager instance;
        public ContentManager Content { private set; get; }

        public Game1 Engine { get; set; }

        private Screen currentScreen;

        public Screen CurrentScreen
        {
            get { return currentScreen; }
            set { currentScreen = value; }
        }

        public static ScreenManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ScreenManager();
                }

                return instance;
            }
        }

        private ScreenManager()
        {
            CurrentScreen = new SplashScreen(this.Engine);
            
        }

        public void ChangeScreens(string screenName)
        {
            switch (screenName)
            {
                case "GameScreen":
                    CurrentScreen = new GameScreen(this.Engine);
                    break;
                case "MenuScreen":
                    CurrentScreen = new MenuScreen(this.Engine);
                    break;
                default:
                    CurrentScreen = new SplashScreen(this.Engine);
                    break;
            }
        }
        
        public void LoadContent(ContentManager Content)
        {
            this.Content = new ContentManager(Content.ServiceProvider, "Content");
            currentScreen.LoadContent();
        }

        public void UnloadContent()
        {
            currentScreen.UnloadContent();
        }

        public void Update(GameTime gameTime)
        {
            currentScreen.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            currentScreen.Draw(spriteBatch);
        }
    }
}
