using System;
using System.Collections.Generic;
using System.Text;

namespace CardsGame
{
    public class Player
    {
        public string Name { get; set; }
        public List<ICard> CardsInHand { get; set; }
        
        public Player(List<ICard> cards)
        {
            CardsInHand = cards;
        }
    }
}
