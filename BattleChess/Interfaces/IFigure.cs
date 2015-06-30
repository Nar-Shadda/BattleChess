using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BattleChess.Enumerations;

namespace BattleChess.Interfaces
{
    
    public interface IFigure : IObject
    {
        Color Color { get; set; }

        List<Position> LegalPositions { get; set; }

        List<Position> CalcValidMoves();
    }
}
