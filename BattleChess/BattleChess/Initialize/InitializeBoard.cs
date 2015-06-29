using BattleChess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleChess.Initialize
{
    public delegate void Initialize();
    public static class InitializeBoard
    {
        private const int BoardTotalRowsAndCols = 8;

        private readonly IList<Type> figureTypes = new List<Type>
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

        
             


        public static void Initialize(IList<IPlayer> players, IBoard board)
        {
            
            var firstPlayer = players[0];
            var secondPlayer = players[1];

            this.AddArmyToBoardRow(firstPlayer, board, 8);
            this.AddPawnsToBoardRow(firstPlayer, board, 7);

            this.AddPawnsToBoardRow(secondPlayer, board, 2);
            this.AddArmyToBoardRow(secondPlayer, board, 1);
        }

        private static void AddPawnsToBoardRow(IPlayer player, IBoard board, int chessRow)
        {
            for (int i = 0; i < BoardTotalRowsAndCols; i++)
            {
                var pawn = new Pawn(player.Color);
                player.AddFigure(pawn);
                var position = new Position(chessRow, (char)(i + 'a'));
                board.AddFigure(pawn, position);
            }
        }

        private static void AddArmyToBoardRow(IPlayer player, IBoard board, int chessRow)
        {
            for (int i = 0; i < BoardTotalRowsAndCols; i++)
            {
                var figureType = this.figureTypes[i];
                var figureInstance = (IFigure)Activator.CreateInstance(figureType, player.Color);
                player.AddFigure(figureInstance);
                var position = new Position(chessRow, (char)(i + 'a'));
                board.AddFigure(figureInstance, position);
            }
        }

    
    }
}
