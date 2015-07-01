using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Color = Microsoft.Xna.Framework.Color;

namespace BattleChess.Screens
{
    class SplashScreen : Screen
    {
        private Texture2D background;

        public SplashScreen()
            : base()
        {

        }

        public override void LoadContent()
        {
            base.LoadContent();

            background = content.Load<Texture2D>("Sprites/Backgrounds/background0");
        }

        public override void Update(GameTime gameTime)
        {
            //TODO: update textures list from engine

        }

        public override void Draw(SpriteBatch spriteBatch)
        {
          
            spriteBatch.Begin();

            spriteBatch.Draw(background, new Rectangle(0,0, background.Width, background.Height), Color.White);

            spriteBatch.End();
        }
    }
}
