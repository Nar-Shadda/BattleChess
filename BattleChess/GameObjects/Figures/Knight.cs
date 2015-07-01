using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BattleChess.Enumerations;

namespace BattleChess.GameObjects.Figures
{
    using global::BattleChess.GameObjects.Board;

    public class Knight : BaseFigure
    {
        public Knight(Color color)
            : base(color, GlobalConstants.Knight + color)
        {
        }

        public override List<Position> CalcValidMoves(Position currentPosition, Board board)
        {
            throw new NotImplementedException();
        }
    }
}
