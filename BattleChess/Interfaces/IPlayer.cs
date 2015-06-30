using BattleChess.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleChess.Interfaces
{
    public interface IPlayer
    {
        string Name { get; }

        Color Color { get; }


    }
}
