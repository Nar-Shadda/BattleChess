﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleChess
{
    public struct Position
    {
        private char row;
        private char col;

        public Position(char col, char row)
            : this()
        {
            this.Row = row;
            this.Col = col;

        }

        public char Row { get; set; }

        public char Col { get; set; }
    }
}
