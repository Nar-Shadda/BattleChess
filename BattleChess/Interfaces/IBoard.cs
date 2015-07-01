using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleChess.Interfaces
{
    public interface IBoard
    {
        Dictionary<Position, IFigure> Squares { get; set; }

        
    }
}
