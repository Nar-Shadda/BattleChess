using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BattleChess.Enumerations;

namespace BattleChess.GameObjects.Figures
{
    using global::BattleChess.GameObjects.Board;

    public class Knight : BaseFigure
    {
        List<Position> LegalMoves = new List<Position>();

        public Knight(Color color)
            : base(color, GlobalConstants.Knight + color)
        {
        }

        public override void CalcLegalPositions(Position currentPosition, Board board)
        {
            
            List<Position> checkLegalPositions = new List<Position>()
            {
                new Position(col++,(char)(row-2)),
                new Position((char)(col+2),row--),
                new Position((char)(col+2),row++),
                new Position(col++,(char)(row+2)),
                new Position(col--,(char)(row+2)),
                new Position((char)(col-2),row++),
                new Position((char)(col-2),row--),
                new Position(col--,(char)(row-2)),
            };
            
            foreach (var position in checkLegalPositions)
            {
                if (this.LegalPositionsMovesCheck(position, board))
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
