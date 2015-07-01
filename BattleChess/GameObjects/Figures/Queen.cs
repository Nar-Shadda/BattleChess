using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BattleChess.Enumerations;

namespace BattleChess.GameObjects.Figures
{
    using global::BattleChess.GameObjects.Board;

    class Queen : BaseFigure
    {
        public Queen(Color color)
            : base(color, GlobalConstants.Queen + color)
        {
        }

        public override List<Position> CalcValidMoves(Position currentPosition, Board board)
        {
            throw new NotImplementedException();
        }
    }
}
