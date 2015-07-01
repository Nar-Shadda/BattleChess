using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BattleChess.Enumerations;

namespace BattleChess.GameObjects.Figures
{
    using global::BattleChess.GameObjects.Board;

    public class Knight : BaseFigure
    {
        public Knight(Color color)
            : base(color, GlobalConstants.Knight + color)
        {
        }

        public override List<Position> CalcValidMoves(Position currentPosition, Board board)
        {
            List<Position> valid = new List<Position>();
            List<Position> checkValid = new List<Position>()
            {
                new Position(currentPosition.Col++,(char)(currentPosition.Row-2)),
                new Position((char)(currentPosition.Col+2),currentPosition.Row--),
                new Position((char)(currentPosition.Col+2),currentPosition.Row++),
                new Position(currentPosition.Col++,(char)(currentPosition.Row+2)),
                new Position(currentPosition.Col--,(char)(currentPosition.Row+2)),
                new Position((char)(currentPosition.Col-2),currentPosition.Row++),
                new Position((char)(currentPosition.Col-2),currentPosition.Row--),
                new Position(currentPosition.Col--,(char)(currentPosition.Row-2)),
            };
            foreach (var position in checkValid)
            {
                if (this.ValidMovesCheck(position, board))
                {
                    valid.Add(position);
                }
            }
            return valid;
        }

        private bool ValidMovesCheck(Position frontPosition, Board board)
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
