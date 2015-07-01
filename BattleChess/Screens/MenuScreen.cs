using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BattleChess.Screens;

using BattleChess;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BattleChess.Screens
{
    class MenuScreen : Screen
    {

        private Texture2D background;

        public override void LoadContent()
        {
            base.LoadContent();

            background = content.Load<Texture2D>("Sprites/Menu/MenuBackground");
        }

        public override void Update(GameTime gameTime)
        {

        }

        public override void Draw(SpriteBatch spriteBatch)
        {

            spriteBatch.Begin();

            spriteBatch.Draw(background, new Rectangle(0, 0, background.Width, background.Height), Color.White);

            spriteBatch.End();
        }
    }
}
