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

            this.FrontValidMovesCheck(currentPosition, board, valid);
            this.BackValidMovesCheck(currentPosition, board, valid);
            this.LeftValidMovesCheck(currentPosition, board, valid);
            this.RightValidMovesCheck(currentPosition, board, valid);


            return valid;
        }

        private void RightValidMovesCheck(Position currentPosition, Board board, List<Position> valid)
        {
            while (true)
            {
                Position frontPosition = new Position(currentPosition.Col, currentPosition.Row++);

                if (board.board.ContainsKey(frontPosition))
                {
                    if (board.board[frontPosition] == null)
                    {
                        valid.Add(frontPosition);
                    }
                    else if (board.board[frontPosition].Color == this.Color)
                    {
                        break;
                    }
                    else if (board.board[frontPosition].Color != this.Color)
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

        private void LeftValidMovesCheck(Position currentPosition, Board board, List<Position> valid)
        {
            while (true)
            {
                Position frontPosition = new Position(currentPosition.Col--, currentPosition.Row);

                if (board.board.ContainsKey(frontPosition))
                {
                    if (board.board[frontPosition] == null)
                    {
                        valid.Add(frontPosition);
                    }
                    else if (board.board[frontPosition].Color == this.Color)
                    {
                        break;
                    }
                    else if (board.board[frontPosition].Color != this.Color)
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

        private void BackValidMovesCheck(Position currentPosition, Board board, List<Position> valid)
        {
            while (true)
            {
                Position frontPosition = new Position(currentPosition.Col, currentPosition.Row--);

                if (board.board.ContainsKey(frontPosition))
                {
                    if (board.board[frontPosition] == null)
                    {
                        valid.Add(frontPosition);
                    }
                    else if (board.board[frontPosition].Color == this.Color)
                    {
                        break;
                    }
                    else if (board.board[frontPosition].Color != this.Color)
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

        private void FrontValidMovesCheck(Position currentPosition, Board board, List<Position> valid)
        {
            while (true) 
            {
                Position frontPosition = new Position(currentPosition.Col, currentPosition.Row++);

                if (board.board.ContainsKey(frontPosition))
                {
                    if (board.board[frontPosition] == null)
                    {
                        valid.Add(frontPosition);
                    }
                    else if (board.board[frontPosition].Color == this.Color)
                    {
                        break;
                    }
                    else if (board.board[frontPosition].Color != this.Color)
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
