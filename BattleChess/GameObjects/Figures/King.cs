using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BattleChess.Enumerations;

namespace BattleChess.GameObjects.Figures
{

    class King : BaseFigure
    {
        public King(Color color)
            : base(color, GlobalConstants.King + color)
        {
        }

        public override List<Position> CalcValidMoves()
        {
            throw new NotImplementedException();
        }
    }
}
