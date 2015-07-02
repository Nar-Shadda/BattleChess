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

        public override void CalcLegalPositions(Position currentPosition, Board board)
        {
            char col = col;
            char row = row;

            if (this.Color == Color.White)
            {
                Position frontPosition = new Position(col, (char)(row+1));
                Position leftDiagonalPosition = new Position((char)(col - 1), (char)(row + 1));
                Position rightDiagonalPosition = new Position((char)(col + 1), (char)(row + 1));

                if (board.Squares.ContainsKey(frontPosition) && board.Squares[frontPosition] == null)
                {
                    LegalPositions.Add(frontPosition);
                }

                if (board.Squares.ContainsKey(leftDiagonalPosition)
                    && board.Squares[leftDiagonalPosition] != null
                    && board.Squares[leftDiagonalPosition].Color == Color.Black)
                {
                    LegalPositions.Add(leftDiagonalPosition);
                }

                if (board.Squares.ContainsKey(rightDiagonalPosition)
                    && board.Squares[rightDiagonalPosition] != null
                    && board.Squares[rightDiagonalPosition].Color == Color.Black)
                {
                    LegalPositions.Add(rightDiagonalPosition);
                }

            }
            else
            {
                Position frontPosition = new Position(col, row--);
                Position leftDiagonalPosition = new Position(col--, row--);
                Position rightDiagonalPosition = new Position(col++, row--);

                if (board.Squares.ContainsKey(frontPosition) && board.Squares[frontPosition] == null)
                {
                    LegalPositions.Add(frontPosition);
                }

                if (board.Squares.ContainsKey(leftDiagonalPosition)
                    && board.Squares[leftDiagonalPosition] != null
                    && board.Squares[leftDiagonalPosition].Color == Color.White)
                {
                    LegalPositions.Add(leftDiagonalPosition);
                }

                if (board.Squares.ContainsKey(rightDiagonalPosition)
                    && board.Squares[rightDiagonalPosition] != null
                    && board.Squares[rightDiagonalPosition].Color == Color.White)
                {
                    LegalPositions.Add(rightDiagonalPosition);
                }
            }

        }
    }
}
