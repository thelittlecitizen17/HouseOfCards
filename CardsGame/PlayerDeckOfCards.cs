using System;
using System.Collections.Generic;
using System.Text;

namespace CardsGame
{
    class PlayerDeckOfCards
    {
        public void CardsDealer(DeckOfCards deckOfCards, Player player)
        {
            Random random = new Random();
            int num = random.Next(1, 5);
            for (int i = 0; i < 5; i++)
            {
                player.cardDesk.Add(deckOfCards._blueCards[i]);
                player.cardDesk.Add(deckOfCards._yellowCards[i]);
                player.cardDesk.Add(deckOfCards._redCards[i]);
                player.cardDesk.Add(deckOfCards._greenCards[i]);
                player.cardDesk.Add(deckOfCards._whiteCards[i]);
            }
        }
    }
}
