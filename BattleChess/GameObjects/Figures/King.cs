using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BattleChess.Enumerations;

namespace BattleChess.GameObjects.Figures
{
    using global::BattleChess.GameObjects.Board;

    public class King : BaseFigure
    {
        public King(Color color)
            : base(color, GlobalConstants.King + color)
        {
        }

        public override void CalcLegalPositions(Position currentPosition, Board board)
        {
            char col = currentPosition.Col;
            char row = currentPosition.Row;

            List<Position> checkLegalPositions = new List<Position>()
            {
                new Position((char)(col+1),(char)(row-1)),
                new Position((char)(col+1),row),
                new Position((char)(col+1),(char)(row+1)),
                new Position(col,(char)(row+1)),
                new Position((char)(col-1),(char)(row+1)),
                new Position((char)(col-1),row),
                new Position((char)(col-1),(char)(row-1)),
                new Position(col,(char)(row-1)),
            };
            foreach (var position in checkLegalPositions)
            {
                if (LegalPositionsMovesCheck(position, board))
                {
                    LegalPositions.Add(position);
                }
            }
        }

        private bool LegalPositionsMovesCheck(Position frontPosition, Board board)
        {
            if (board.Squares.ContainsKey(frontPosition))
            {
                if (board.Squares[frontPosition] == null)
                {
                    return true;
                }
                else if (board.Squares[frontPosition].Color == this.Color)
                {

                    return false;
                }
                else
                {
                    return true;

                }
            }
            else
            {
                return false;
            }
        }
    }
}
