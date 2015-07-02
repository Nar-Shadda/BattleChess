using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BattleChess.Enumerations;

namespace BattleChess.GameObjects.Figures
{
    using global::BattleChess.GameObjects.Board;

    public class Bishop : BaseFigure
    {
        List<Position> LegalPositions = new List<Position>();

        public Bishop(Color color)
            : base(color, GlobalConstants.Bishop + color)
        {
        }

        public override void CalcLegalPositions(Position currentPosition, Board board)
        {
            this.RightUpDiagonalCheck(currentPosition, board);
            this.LeftUpDiagonalCheck(currentPosition, board);
            this.LeftDownDiagonalCheck(currentPosition, board);
            this.RightDownDiagonalCheck(currentPosition, board);
            
        }

        private void RightDownDiagonalCheck(Position currentPosition, Board board)
        {
            while (true)
            {
                Position frontPosition = new Position(col++, row++);

                if (board.Squares.ContainsKey(frontPosition))
                {
                    if (board.Squares[frontPosition] == null)
                    {
                        LegalPositions.Add(frontPosition);
                    }
                    else if (board.Squares[frontPosition].Color == this.Color)
                    {
                        break;
                    }
                    else if (board.Squares[frontPosition].Color != this.Color)
                    {
                        LegalPositions.Add(frontPosition);
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

        private void LeftDownDiagonalCheck(Position currentPosition, Board board)
        {
            while (true)
            {
                Position frontPosition = new Position(col--, row++);

                if (board.Squares.ContainsKey(frontPosition))
                {
                    if (board.Squares[frontPosition] == null)
                    {
                        LegalPositions.Add(frontPosition);
                    }
                    else if (board.Squares[frontPosition].Color == this.Color)
                    {
                        break;
                    }
                    else if (board.Squares[frontPosition].Color != this.Color)
                    {
                        LegalPositions.Add(frontPosition);
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

        private void LeftUpDiagonalCheck(Position currentPosition, Board board)
        {
            while (true)
            {
                Position frontPosition = new Position(col--, row--);

                if (board.Squares.ContainsKey(frontPosition))
                {
                    if (board.Squares[frontPosition] == null)
                    {
                        LegalPositions.Add(frontPosition);
                    }
                    else if (board.Squares[frontPosition].Color == this.Color)
                    {
                        break;
                    }
                    else if (board.Squares[frontPosition].Color != this.Color)
                    {
                        LegalPositions.Add(frontPosition);
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

        private void RightUpDiagonalCheck(Position currentPosition, Board board)
        {
            while (true)
            {
                Position frontPosition = new Position(col++, row--);

                if (board.Squares.ContainsKey(frontPosition))
                {
                    if (board.Squares[frontPosition] == null)
                    {
                        LegalPositions.Add(frontPosition);
                    }
                    else if (board.Squares[frontPosition].Color == this.Color)
                    {
                        break;
                    }
                    else if (board.Squares[frontPosition].Color != this.Color)
                    {
                        LegalPositions.Add(frontPosition);
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
