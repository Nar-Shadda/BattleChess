using BattleChess.Enumerations;
using BattleChess.GameObjects.Board;
using BattleChess.GameObjects.Figures;
using BattleChess.Interfaces;
using System;
using System.Collections.Generic;


namespace BattleChess.Initialize
{
    
    public static class InitializeBoard
    {
        private const int BoardTotalRowsAndCols = 8;

        private static readonly IList<Type> figureTypes = new List<Type>
            {
                typeof(Rook), 
                typeof(Knight), 
                typeof(Bishop), 
                typeof(Queen), 
                typeof(King), 
                typeof(Bishop), 
                typeof(Knight), 
                typeof(Rook)
            };

        public static void Initialize(Board board)
        {
            AddArmyToBoardRow(Color.Black, board,  '8');
            AddPawnsToBoardRow(Color.Black, board, '7');

            AddPawnsToBoardRow(Color.White, board, '2');
            AddArmyToBoardRow(Color.White, board, '1');

            AddEmptyPositions(board);
        }

        private static void AddEmptyPositions(Board board)
        {
            for (char i = '3'; i <= '6'; i++)
            {
                for (char j = 'a'; j <= 'h'; j++)
                {
                    Position position = new Position(j, i);
                    board.Squares[position] = null;
                }
            }
        }

        private static void AddPawnsToBoardRow(Color color, Board board, char chessRow)
        {
            for (int i = 0; i < BoardTotalRowsAndCols; i++)
            {
                var pawn = new Pawn(color);
                var position = new Position((char)(i + 'a'), chessRow);
                
                board.AddFigure(pawn, position);
            }
        }

        private static void AddArmyToBoardRow(Color color, Board board, char chessRow)
        {
            for (int i = 0; i < BoardTotalRowsAndCols; i++)
            {
                var figureType = figureTypes[i];
                var figureInstance = (IFigure)Activator.CreateInstance(figureType, color);
                var position = new Position((char)(i + 'a'), chessRow);
                board.AddFigure(figureInstance, position);
            }
        }
    }
}
