using System;
using System.Collections.Generic;
using System.Text;

namespace CardsGame
{
    class Player
    {
        public string name { get; set; }
        public List<ICard> cardDesk { get; set; }
        
        public Player()
        {
            cardDesk = new List<ICard>();
        }
    }
}
