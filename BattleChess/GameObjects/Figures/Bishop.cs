using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BattleChess.Enumerations;

namespace BattleChess.GameObjects.Figures
{
    using global::BattleChess.GameObjects.Board;

    class Bishop : BaseFigure
    {
        public Bishop(Color color)
            : base(color, GlobalConstants.Bishop + color)
        {
        }

        public override List<Position> CalcValidMoves(Position currentPosition, Board board)
        {
            List<Position> valid = new List<Position>();
            this.RightUpDiagonalCheck(currentPosition,board,valid);
            this.LeftUpDiagonalCheck(currentPosition, board, valid);
            this.LeftDownDiagonalCheck(currentPosition, board, valid);
            this.RightDownDiagonalCheck(currentPosition, board, valid);
            return valid;
        }

        private void RightDownDiagonalCheck(Position currentPosition, Board board, List<Position> valid)
        {
            while (true)
            {
                Position frontPosition = new Position(currentPosition.Col++, currentPosition.Row++);

                if (board.Squares.ContainsKey(frontPosition))
                {
                    if (board.Squares[frontPosition] == null)
                    {
                        valid.Add(frontPosition);
                    }
                    else if (board.Squares[frontPosition].Color == this.Color)
                    {
                        break;
                    }
                    else if (board.Squares[frontPosition].Color != this.Color)
                    {
                        valid.Add(frontPosition);
                        break;
                    }
                }
                else
                {
                    break;
                }
                currentPosition = frontPosition;
            }
        }

        private void LeftDownDiagonalCheck(Position currentPosition, Board board, List<Position> valid)
        {
            while (true)
            {
                Position frontPosition = new Position(currentPosition.Col--, currentPosition.Row++);

                if (board.Squares.ContainsKey(frontPosition))
                {
                    if (board.Squares[frontPosition] == null)
                    {
                        valid.Add(frontPosition);
                    }
                    else if (board.Squares[frontPosition].Color == this.Color)
                    {
                        break;
                    }
                    else if (board.Squares[frontPosition].Color != this.Color)
                    {
                        valid.Add(frontPosition);
                        break;
                    }
                }
                else
                {
                    break;
                }
                currentPosition = frontPosition;
            }
        }

        private void LeftUpDiagonalCheck(Position currentPosition, Board board, List<Position> valid)
        {
            while (true)
            {
                Position frontPosition = new Position(currentPosition.Col--, currentPosition.Row--);

                if (board.Squares.ContainsKey(frontPosition))
                {
                    if (board.Squares[frontPosition] == null)
                    {
                        valid.Add(frontPosition);
                    }
                    else if (board.Squares[frontPosition].Color == this.Color)
                    {
                        break;
                    }
                    else if (board.Squares[frontPosition].Color != this.Color)
                    {
                        valid.Add(frontPosition);
                        break;
                    }
                }
                else
                {
                    break;
                }
                currentPosition = frontPosition;
            }
        }

        private void RightUpDiagonalCheck(Position currentPosition, Board board, List<Position> valid)
        {
            while (true)
            {
                Position frontPosition = new Position(currentPosition.Col++, currentPosition.Row--);

                if (board.Squares.ContainsKey(frontPosition))
                {
                    if (board.Squares[frontPosition] == null)
                    {
                        valid.Add(frontPosition);
                    }
                    else if (board.Squares[frontPosition].Color == this.Color)
                    {
                        break;
                    }
                    else if (board.Squares[frontPosition].Color != this.Color)
                    {
                        valid.Add(frontPosition);
                        break;
                    }
                }
                else
                {
                    break;
                }
                currentPosition = frontPosition;
            }
        }
    }
}
