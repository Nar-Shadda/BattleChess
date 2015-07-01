using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Color = Microsoft.Xna.Framework.Color;

namespace BattleChess.Screens
{
    class SplashScreen : Screen
    {
        private int screenCount = 1;

        private Texture2D background;


        public override void LoadContent()
        {
            base.LoadContent();

            background = content.Load<Texture2D>("Sprites/Backgrounds/SplashScreen01");
        }

        public override void Update(GameTime gameTime)
        {
            KeyboardState keyboard = Keyboard.GetState();

            if (keyboard.IsKeyDown(Keys.Space) && screenCount < 4)
            {
                screenCount++;
                background = content.Load<Texture2D>("Sprites/Backgrounds/SplashScreen0" + screenCount);
                Thread.Sleep(1000);
            }

        }

        public override void Draw(SpriteBatch spriteBatch)
        {

            spriteBatch.Begin();

            spriteBatch.Draw(background, new Rectangle(0, 0, background.Width, background.Height), Color.White);

            spriteBatch.End();
        }
    }
}
