using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleChess.Interfaces
{
    public interface IBoard
    {
        void AddFigure(IFigure figure, Position position);
    }
}
