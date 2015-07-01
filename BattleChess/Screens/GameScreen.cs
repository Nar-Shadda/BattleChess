using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BattleChess.Screens

{
    class GameScreen : Screen
    {

        public GameScreen() : base()
        {
        }

        public override void LoadContent()
        {
            content = new ContentManager(
                ScreenManager.Instance.Content.ServiceProvider, "Content");
        }

        public override void UnloadContent()
        {
            content.Unload();
        }

        public override void Update(GameTime gameTime)
        {
            //TODO: get list from engine
            //this.drawables = Game1.board.Squares;
        }

        
        public override void Draw(SpriteBatch spriteBatch)
        {
            
        }
    }
}
