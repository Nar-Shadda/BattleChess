using BattleChess.GameObjects.Board;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using Microsoft.Xna.Framework.Content;

using BattleChess.Initialize;
using BattleChess.Engine;
using BattleChess.Interfaces;
using System.Collections.Generic;
using System;
using BattleChess.Screens;

namespace BattleChess
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Engine.Engine engine;

        private Texture2D clickedFigure;
        private Rectangle clickedFigureRectangle;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            graphics.PreferredBackBufferWidth = GlobalConstants.WindowWidth;
            graphics.PreferredBackBufferHeight = GlobalConstants.WindowHeight;
        }




        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            this.IsMouseVisible = true;


            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            //TODO: Load content here - text, sprites, audio etc. 
            engine = new Engine.Engine();
            ScreenManager.Instance.Engine = engine;
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            ScreenManager.Instance.LoadContent(Content);

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            KeyboardState keyboard = Keyboard.GetState();

            if (keyboard.IsKeyDown(Keys.Enter))
            {
                ScreenManager.Instance.ChangeScreens("GameScreen");
            }

            if (keyboard.IsKeyDown(Keys.Escape))
            {
                ScreenManager.Instance.ChangeScreens("MenuScreen");
            }
            //if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            // Exit();

            // TODO: Add your update logic here

            MouseState mouse = Mouse.GetState();
            if (mouse.LeftButton == ButtonState.Pressed)
            {
                int x = mouse.X - GlobalConstants.BoardTopLeftX;
                int y = mouse.Y - GlobalConstants.BoardTopLeftY;
               
                Position squareClicked = engine.GetCLickedSquare(x, y);

                if (engine.Board.Squares.ContainsKey(squareClicked) && engine.Board.Squares[squareClicked] != null)
                {
                    
                    clickedFigure = Content.Load<Texture2D>(engine.Board.Squares[squareClicked].ImagePath);
                    
                    clickedFigureRectangle = new Rectangle(300, 300, 80, 80);
                    //engine.Board.Squares[squareClicked] = null;
                }
                
            }

            ScreenManager.Instance.CurrentScreen.Update(gameTime);
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.WhiteSmoke);

            // TODO: Add your drawing code here

            if (clickedFigure != null)
            {
                spriteBatch.Begin(); 
                spriteBatch.Draw(clickedFigure, clickedFigureRectangle, Microsoft.Xna.Framework.Color.White);
                spriteBatch.End();
            }
            
            ScreenManager.Instance.CurrentScreen.Draw(spriteBatch);
            
            base.Draw(gameTime);
        }
        
        
    }
}
