using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleChess.Exceptions
{
    public class CostomExeption : Exception
    {
        public CostomExeption(string message)
            :base(message)
        {
        }
    }
}
