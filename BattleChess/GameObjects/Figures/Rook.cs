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
this.FrontLegalPositionsMovesCheck(currentPosition, board);
            this.BackLegalPositionsMovesCheck(currentPosition, board);
            this.LeftLegalPositionsMovesCheck(currentPosition, board);
            this.RightLegalPositionsMovesCheck(currentPosition, board);
        }

        private void RightLegalPositionsMovesCheck(Position currentPosition, Board board)
        {
            char col = currentPosition.Col;
            char row = currentPosition.Row;
            while (true)
            {
                Position frontPosition = new Position(col++, row);

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
                Position frontPosition = new Position(col--, row);

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
                Position frontPosition = new Position(col, row++);

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
            while (true)
            {
                Position frontPosition = new Position(col, row--);

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
