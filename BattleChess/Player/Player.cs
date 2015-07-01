using BattleChess.Enumerations;
using BattleChess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleChess
{
    class Player : IPlayer
    {

        public Player(string name, Color color)
        {
            // TODO: validate name length
            this.Name = name;
            this.Color = color;
            this.HasMoved = false;
        }
        public bool HasMoved { get; set; }

        public string Name { get; private set; }

        public Color Color { get; private set; }
    }
}
