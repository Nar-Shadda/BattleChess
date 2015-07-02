using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BattleChess.Enumerations;

namespace BattleChess.GameObjects.Figures
{
    using global::BattleChess.GameObjects.Board;

    class Rook : BaseFigure
    {
        List<Position> LegalPositions { get; set; }

        public Rook(Color color)
            : base(color, GlobalConstants.Rook + color)
        {
        }

        public override void CalcLegalPositions(Position currentPosition, Board board)
        {
            List<Position> LegalPositions = new List<Position>();

            this.FrontLegalPositionsMovesCheck(currentPosition, board, LegalPositions);
            this.BackLegalPositionsMovesCheck(currentPosition, board, LegalPositions);
            this.LeftLegalPositionsMovesCheck(currentPosition, board, LegalPositions);
            this.RightLegalPositionsMovesCheck(currentPosition, board, LegalPositions);
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
