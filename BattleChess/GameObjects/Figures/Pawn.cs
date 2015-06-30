using BattleChess.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BattleChess.Enumerations;

namespace BattleChess.GameObjects.Figures
{
    class Pawn : BaseFigure
    {
        public Pawn(Color color)
            : base(color)
        {
        }

        public override List<Position> CalcValidMoves()
        {
            throw new NotImplementedException();
        }
    }
}
