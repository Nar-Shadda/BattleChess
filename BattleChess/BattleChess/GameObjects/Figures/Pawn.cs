using BattleChess.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleChess.GameObjects.Figures
{
    class Pawn : BaseFigure
    {
        private Color color;

        public Pawn(Color color)
        {
            this.Color = color;
        }
        public Color Color { get; set; }
    }
}
