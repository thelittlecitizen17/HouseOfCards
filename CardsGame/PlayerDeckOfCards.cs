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
            player.cardDesk.Add(deckOfCards._blueCards[num]);
            int i = random.Next(1, 5);
            player.cardDesk.Add(deckOfCards._yellowCards[i]);
            int t = random.Next(1, 5);
            player.cardDesk.Add(deckOfCards._redCards[t]);
            int f = random.Next(1, 5);
            player.cardDesk.Add(deckOfCards._greenCards[f]);
            int l = random.Next(1, 5);
            player.cardDesk.Add(deckOfCards._whiteCards[l]);

        }
    }
}
