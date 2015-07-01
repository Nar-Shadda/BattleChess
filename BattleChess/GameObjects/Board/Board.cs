namespace BattleChess.GameObjects.Board
{
    using System.Collections.Generic;

    using global::BattleChess.Initialize;
    using global::BattleChess.Interfaces;

    public class Board : IBoard
    {

        public Board() 
        {

            this.Squares = new Dictionary<Position, IFigure>();
            InitializeBoard.Initialize(this);

        }

        public Dictionary<Position, IFigure> Squares { get; set; }

        public void AddFigure(IFigure figure, Position position)
        {
            this.Squares[position] = figure;
        }
    }
}
