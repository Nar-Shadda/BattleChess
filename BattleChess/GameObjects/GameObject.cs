using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleChess.GameObjects
{
    public abstract class GameObject
    {
        private Position position;
        private int width;
        private int height;

        public GameObject()
        {
            
        }

        public Position Position { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
