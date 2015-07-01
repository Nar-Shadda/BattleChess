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
        
        public MenuScreen(Engine.Engine engine) : base(engine)
        {
        }

        public override void LoadContent()
        {
            //ScreenManager.Instance.Engine.Board
        }

        public override void Update(GameTime gameTime)
        {
            throw new NotImplementedException();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
         
        }
    }
}
