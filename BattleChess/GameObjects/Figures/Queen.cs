using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleChess.GameObjects.Figures
{
    using global::BattleChess.Enumerations;

    class Queen : BaseFigure
    {
        public Queen(Color color)
            : base(color)
        {
        }

        public override List<Position> CalcValidMoves()
        {
            throw new NotImplementedException();
        }
    }
}
