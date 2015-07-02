using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BattleChess.Enumerations;

namespace BattleChess.Interfaces
{
    using global::BattleChess.GameObjects.Board;

    public interface IFigure : IObject, IDrawable
    {
        Color Color { get; set; }

        List<Position> LegalPositions { get; set; }

        void CalcLegalPositions(Position currentPosition, Board board);
    }
}
