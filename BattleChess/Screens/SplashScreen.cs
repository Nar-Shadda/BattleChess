﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BattleChess.Screens;

using BattleChess.Engine;
using BattleChess.GameObjects.Figures;
using BattleChess.Interfaces;
using BattleChess.Enumerations;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Color = Microsoft.Xna.Framework.Color;

namespace BattleChess.Screens
{
    class SplashScreen : Screen
    {

        private Texture2D board;
        private Texture2D border;
        private Texture2D background;

        private Dictionary<IFigure, Texture2D> textures;

        public SplashScreen()
            : base()
        {

        }

        public override void LoadContent()
        {
            base.LoadContent();

            textures = new Dictionary<IFigure, Texture2D>();

            board = content.Load<Texture2D>("Sprites/Boards/board0");
            border = content.Load<Texture2D>("Sprites/Borders/border0");
            background = content.Load<Texture2D>("Sprites/Backgrounds/background0");

            foreach (var fig in ScreenManager.Instance.Engine.Board.Squares.Values)
            {
                if (fig != null)
                {
                    Texture2D figure = content.Load<Texture2D>(fig.ImagePath);
                    textures.Add(fig, figure);
                }
            }


        }

        public override void Update(GameTime gameTime)
        {
            //TODO: update textures list from engine

        }

        public override void Draw(SpriteBatch spriteBatch)
        {
          
            spriteBatch.Begin();

            //draw background
            spriteBatch.Draw(background, new Rectangle(0,0, background.Width, background.Height), Microsoft.Xna.Framework.Color.White);

            //draw border
            spriteBatch.Draw(border, new Rectangle(0, 0, border.Width, border.Height), Microsoft.Xna.Framework.Color.White);

            //draw board
            spriteBatch.Draw(board, new Rectangle(GlobalConstants.BoardTopLeftX, GlobalConstants.BoardTopLeftY, board.Width, board.Height), Microsoft.Xna.Framework.Color.White);

            //draw figures
            foreach (var square in ScreenManager.Instance.Engine.Board.Squares.Keys)
            {

                if (ScreenManager.Instance.Engine.Board.Squares[square] != null)
                {
                    var currentFigure = ScreenManager.Instance.Engine.Board.Squares[square];
                    
                    int x = ('8' - square.Row) * textures[currentFigure].Height + GlobalConstants.BoardTopLeftX;
                    int y = (square.Col - 'a') * textures[currentFigure].Width + GlobalConstants.BoardTopLeftY;

                    spriteBatch.Draw(textures[currentFigure], new Rectangle(y, x, textures[currentFigure].Width, textures[currentFigure].Width), Microsoft.Xna.Framework.Color.White);
                }
            }

            spriteBatch.End();
        }
    }
}
