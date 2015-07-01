
namespace BattleChess
{
    using global::BattleChess.Enumerations;
    using global::BattleChess.Exceptions;
    using global::BattleChess.Interfaces;

    class Player : IPlayer
    {
        private string name;

        public Player(string name, Color color)
        {
            this.Name = name;
            this.Color = color;
            this.HasMoved = false;
        }

        public bool HasMoved { get; set; }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (value.Length < GlobalConstants.NameMinLenght 
                    || value.Length > GlobalConstants.NameMaxLenght
                    || value == GlobalConstants.forbidenName)
                {
                    throw new CostomExeption("Name must be between 3-10 simbols and diferent from \"kur\"");
                }

                this.name = value;
            }
        }

        public Color Color { get; private set; }
    }
}
