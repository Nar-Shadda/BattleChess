using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BattleChess.Enumerations;

namespace BattleChess.GameObjects.Figures
{
    using global::BattleChess.GameObjects.Board;

    public class King : BaseFigure
    {
        public King(Color color)
            : base(color, GlobalConstants.King + color)
        {
        }

        public override List<Position> CalcValidMoves(Position currentPosition, Board board)
        {
            List<Position> checkValid = new List<Position>()
            {
                new Position(currentPosition.Col++,currentPosition.Row--),
                new Position(currentPosition.Col++,currentPosition.Row),
                new Position(currentPosition.Col++,currentPosition.Row++),
                new Position(currentPosition.Col,currentPosition.Row++),
                new Position(currentPosition.Col--,currentPosition.Row++),
                new Position(currentPosition.Col--,currentPosition.Row),
                new Position(currentPosition.Col--,currentPosition.Row--),
                new Position(currentPosition.Col,currentPosition.Row--),
            };
            return checkValid.Where(position => this.ValidMovesCheck(position, board)).ToList();
        }

        private bool ValidMovesCheck(Position frontPosition,Board board)
        {
                if (board.Squares.ContainsKey(frontPosition))
                {
                    if (board.Squares[frontPosition] == null)
                    {
                        return true;
                    }
                    else if (board.Squares[frontPosition].Color == this.Color)
                    {
         
                        return false;
                    }
                    else
                    {
                        return true;
                        
                    }
                }
                else
                {
                    return false;
                }
        }
    }
}
