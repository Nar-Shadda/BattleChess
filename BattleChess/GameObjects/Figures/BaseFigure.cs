using BattleChess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BattleChess.Enumerations;

namespace BattleChess.GameObjects.Figures
{

    abstract class BaseFigure : IFigure
    {
        protected BaseFigure(Color color, string imagePath)
        {
            this.Color = color;
            this.LegalPositions = new List<Position>();
            this.ImagePath = imagePath;
        }


        public Color Color { get; set; }

        public List<Position> LegalPositions { get; set; }

        public string ImagePath { get; set; }

        public abstract List<Position> CalcValidMoves();

    }
}
