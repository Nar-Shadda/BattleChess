using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BattleChess.Enumerations;

namespace BattleChess.GameObjects.Figures
{
    using global::BattleChess.GameObjects.Board;

    public class Queen : BaseFigure
    {
        List<Position> LegalPositions = new List<Position>();

        public Queen(Color color)
            : base(color, GlobalConstants.Queen + color)
        {
        }

        public override void CalcLegalPositions(Position currentPosition, Board board)
        {

            
            this.RightUpDiagonalCheck(currentPosition, board);
            this.LeftUpDiagonalCheck(currentPosition, board);
            this.LeftDownDiagonalCheck(currentPosition, board);
            this.RightDownDiagonalCheck(currentPosition, board);
            this.FrontLegalPositionsMovesCheck(currentPosition, board);
            this.BackLegalPositionsMovesCheck(currentPosition, board);
            this.LeftLegalPositionsMovesCheck(currentPosition, board);
            this.RightLegalPositionsMovesCheck(currentPosition, board);
        }

        private void RightDownDiagonalCheck(Position currentPosition, Board board)
        {
            char col = currentPosition.Col;
            char row = currentPosition.Row;

            while (true)
            {
                Position frontPosition = new Position((char)(col+1), (char)(row+1));

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
            char col = currentPosition.Col;
            char row = currentPosition.Row;

            while (true)
            {
                Position frontPosition = new Position((char)(col-1), (char)(row+1));

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
            char col = currentPosition.Col;
            char row = currentPosition.Row;

            while (true)
            {
                Position frontPosition = new Position((char)(col-1), (char)(row-1));

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
            char col = currentPosition.Col;
            char row = currentPosition.Row;

            while (true)
            {
                Position frontPosition = new Position((char)(col+1), (char)(row-1));

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

        private void RightLegalPositionsMovesCheck(Position currentPosition, Board board)
        {
            char col = currentPosition.Col;
            char row = currentPosition.Row;

            while (true)
            {
                Position frontPosition = new Position((char)(col+1), row);

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

        private void LeftLegalPositionsMovesCheck(Position currentPosition, Board board)
        {
            char col = currentPosition.Col;
            char row = currentPosition.Row;

            while (true)
            {
                Position frontPosition = new Position((char)(col-1), row);

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

        private void BackLegalPositionsMovesCheck(Position currentPosition, Board board)
        {
            char col = currentPosition.Col;
            char row = currentPosition.Row;

            while (true)
            {
                Position frontPosition = new Position(col, (char)(row+1));

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

        private void FrontLegalPositionsMovesCheck(Position currentPosition, Board board)
        {
            char col = currentPosition.Col;
            char row = currentPosition.Row;

            while (true)
            {
                Position frontPosition = new Position(col, (char)(row-1));

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
