using BattleChess.Enumerations;
using BattleChess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BattleChess.GameObjects.Figures;

namespace BattleChess.GameObjects.Board
{
    public class Board : IBoard
    {
        public Dictionary<Position, IFigure> board = new Dictionary<Position, IFigure>();

        public Board() 
        {
                
        }


        public void AddFigure(IFigure figure, Position position)
        {
            board[position] = figure;
        }
    }
}
