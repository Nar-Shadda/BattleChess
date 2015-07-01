using BattleChess.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleChess.GameObjects.Figures
{
    using global::BattleChess.GameObjects.Board;
    using global::BattleChess.Interfaces;

    class Pawn : BaseFigure
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

                if (board.board.ContainsKey(frontPosition) && board.board[frontPosition] == null)
                {
                    valid.Add(frontPosition);
                }
                if (board.board.ContainsKey(leftDiagonalPosition)
                    && board.board[leftDiagonalPosition] != null
                    && board.board[leftDiagonalPosition].Color == Color.Black)
                {
                    valid.Add(leftDiagonalPosition);
                }
                if (board.board.ContainsKey(rightDiagonalPosition)
                    && board.board[rightDiagonalPosition] != null
                    && board.board[rightDiagonalPosition].Color == Color.Black)
                {
                    valid.Add(rightDiagonalPosition);
                }

            }
            else
            {
                Position frontPosition = new Position(currentPosition.Col, currentPosition.Row--);
                Position leftDiagonalPosition = new Position(currentPosition.Col--, currentPosition.Row--);
                Position rightDiagonalPosition = new Position(currentPosition.Col++, currentPosition.Row--);

                if (board.board.ContainsKey(frontPosition) && board.board[frontPosition] == null)
                {
                    valid.Add(frontPosition);
                }
                if (board.board.ContainsKey(leftDiagonalPosition)
                    && board.board[leftDiagonalPosition] != null
                    && board.board[leftDiagonalPosition].Color == Color.Black)
                {
                    valid.Add(leftDiagonalPosition);
                }
                if (board.board.ContainsKey(rightDiagonalPosition)
                    && board.board[rightDiagonalPosition] != null
                    && board.board[rightDiagonalPosition].Color == Color.Black)
                {
                    valid.Add(rightDiagonalPosition);
                }
            }

            return valid.ToList();
        }
    }
}
