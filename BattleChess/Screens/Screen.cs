using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework.Content;

using BattleChess;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BattleChess.Screens
{
    public abstract class Screen
    {
        private IList<IDrawable> drawables;

        protected ContentManager content;

        public Type Type;

        public Screen()
        {
            Type = this.GetType();
        }

        public virtual void LoadContent()
        {
            content = new ContentManager(
                ScreenManager.Instance.Content.ServiceProvider, "Content");
        }

        public virtual void UnloadContent()
        {
            content.Unload();
        }

        public virtual void Update(GameTime gameTime)
        {
            //TODO: read updated list with drawables
        }

        public abstract void Draw(SpriteBatch spriteBatch);
    }
}