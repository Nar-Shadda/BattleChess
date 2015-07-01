using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleChess
{
    public struct Position
    {

<<<<<<< HEAD
        public Position(char col, char row)
            : this()
=======
        public Position(char col, char row) : this()
>>>>>>> dcd4ab7c9902ae54e7225a5d672899425e0dc5cb
        {
            this.Row = row;
            this.Col = col;

        }

        public char Row { get; set; }

        public char Col { get; set; }
    }
}
