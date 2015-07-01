using BattleChess.Enumerations;
using BattleChess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BattleChess.GameObjects.Figures;
using BattleChess.Initialize;

namespace BattleChess.GameObjects.Board
{
    public class Board : IBoard
    {

        public Board() 
        {

            this.Squares = new Dictionary<Position, IFigure>();
            InitializeBoard.Initialize(this);

        }

        public Dictionary<Position, IFigure> Squares { get; set; }

        public void AddFigure(IFigure figure, Position position)
        {
            this.Squares[position] = figure;
        }
    }
}
