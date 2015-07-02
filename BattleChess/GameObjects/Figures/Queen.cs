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
            
            this.RightUpDiagonalCheck(currentPosition, board, LegalPositions);
            this.LeftUpDiagonalCheck(currentPosition, board, LegalPositions);
            this.LeftDownDiagonalCheck(currentPosition, board, LegalPositions);
            this.RightDownDiagonalCheck(currentPosition, board, LegalPositions);
            this.FrontLegalPositionsMovesCheck(currentPosition, board, LegalPositions);
            this.BackLegalPositionsMovesCheck(currentPosition, board, LegalPositions);
            this.LeftLegalPositionsMovesCheck(currentPosition, board, LegalPositions);
            this.RightLegalPositionsMovesCheck(currentPosition, board, LegalPositions);
        }

        private void RightDownDiagonalCheck(Position currentPosition, Board board, List<Position> LegalPositions)
        {
            while (true)
            {
                Position frontPosition = new Position(currentPosition.Col++, currentPosition.Row++);

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

        private void LeftDownDiagonalCheck(Position currentPosition, Board board, List<Position> LegalPositions)
        {
            while (true)
            {
                Position frontPosition = new Position(currentPosition.Col--, currentPosition.Row++);

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

        private void LeftUpDiagonalCheck(Position currentPosition, Board board, List<Position> LegalPositions)
        {
            while (true)
            {
                Position frontPosition = new Position(currentPosition.Col--, currentPosition.Row--);

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

        private void RightUpDiagonalCheck(Position currentPosition, Board board, List<Position> LegalPositions)
        {
            while (true)
            {
                Position frontPosition = new Position(currentPosition.Col++, currentPosition.Row--);

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

        private void RightLegalPositionsMovesCheck(Position currentPosition, Board board, List<Position> LegalPositions)
        {
            while (true)
            {
                Position frontPosition = new Position(currentPosition.Col++, currentPosition.Row);

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

        private void LeftLegalPositionsMovesCheck(Position currentPosition, Board board, List<Position> LegalPositions)
        {
            while (true)
            {
                Position frontPosition = new Position(currentPosition.Col--, currentPosition.Row);

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

        private void BackLegalPositionsMovesCheck(Position currentPosition, Board board, List<Position> LegalPositions)
        {
            while (true)
            {
                Position frontPosition = new Position(currentPosition.Col, currentPosition.Row++);

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

        private void FrontLegalPositionsMovesCheck(Position currentPosition, Board board, List<Position> LegalPositions)
        {
            while (true)
            {
                Position frontPosition = new Position(currentPosition.Col, currentPosition.Row--);

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
