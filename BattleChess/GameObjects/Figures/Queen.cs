using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BattleChess.Enumerations;

namespace BattleChess.GameObjects.Figures
{

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
