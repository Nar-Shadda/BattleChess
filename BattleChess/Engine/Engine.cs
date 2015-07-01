using BattleChess.Enumerations;
using BattleChess.GameObjects.Board;
using BattleChess.Initialize;
using BattleChess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleChess.Engine
{
    public class Engine
    {
        private Board board;
        private List<IPlayer> players;

        public Engine()
        {
            
            this.Board = new Board();
            this.players = new List<IPlayer> 
            {
                new Player("Gosho", Color.White),
                new Player("Pesho", Color.Black)
            };

        }


        public IEnumerable<IPlayer> Players
        {
            get
            {
                return new List<IPlayer>(this.players);
            }
        }

        public Board Board { get; set; }
    }
}
