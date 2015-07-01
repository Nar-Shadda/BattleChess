using BattleChess.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleChess.GameObjects.Figures
{
    using global::BattleChess.GameObjects.Board;
    using global::BattleChess.Interfaces;

    public class Pawn : BaseFigure
    {
        public Pawn(Color color)
            : base(color, GlobalConstants.Pawn + color)
        {
            
        }

        public override List<Position> CalcValidMoves(Position currentPosition,Board board)
        {
            List<Position> valid = new List<Position>();
            if (this.Color == Color.White)
            {
                Position frontPosition = new Position(currentPosition.Col, currentPosition.Row++);
                Position leftDiagonalPosition = new Position(currentPosition.Col--, currentPosition.Row ++);
                Position rightDiagonalPosition = new Position(currentPosition.Col++, currentPosition.Row++);

                if (board.Squares.ContainsKey(frontPosition) && board.Squares[frontPosition] == null)
                {
                    valid.Add(frontPosition);
                }
                if (board.Squares.ContainsKey(leftDiagonalPosition)
                    && board.Squares[leftDiagonalPosition] != null
                    && board.Squares[leftDiagonalPosition].Color == Color.Black)
                {
                    valid.Add(leftDiagonalPosition);
                }
                if (board.Squares.ContainsKey(rightDiagonalPosition)
                    && board.Squares[rightDiagonalPosition] != null
                    && board.Squares[rightDiagonalPosition].Color == Color.Black)
                {
                    valid.Add(rightDiagonalPosition);
                }

            }
            else
            {
                Position frontPosition = new Position(currentPosition.Col, currentPosition.Row--);
                Position leftDiagonalPosition = new Position(currentPosition.Col--, currentPosition.Row--);
                Position rightDiagonalPosition = new Position(currentPosition.Col++, currentPosition.Row--);

                if (board.Squares.ContainsKey(frontPosition) && board.Squares[frontPosition] == null)
                {
                    valid.Add(frontPosition);
                }
                if (board.Squares.ContainsKey(leftDiagonalPosition)
                    && board.Squares[leftDiagonalPosition] != null
                    && board.Squares[leftDiagonalPosition].Color == Color.White)
                {
                    valid.Add(leftDiagonalPosition);
                }
                if (board.Squares.ContainsKey(rightDiagonalPosition)
                    && board.Squares[rightDiagonalPosition] != null
                    && board.Squares[rightDiagonalPosition].Color == Color.White)
                {
                    valid.Add(rightDiagonalPosition);
                }
            }

            return valid.ToList();
        }
    }
}
