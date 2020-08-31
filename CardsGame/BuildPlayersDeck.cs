using System;
using System.Collections.Generic;
using System.Text;

namespace CardsGame
{
    class BuildPlayersDeck
    {
        public void CardsDealer(DeckOfCards deckOfCards, Player player)
        {
            Random random = new Random();
            int num = random.Next(1, 5);
            player.CardsInHand.Add(deckOfCards._blueCards[num]);
            int i = random.Next(1, 5);
            player.CardsInHand.Add(deckOfCards._yellowCards[i]);
            int t = random.Next(1, 5);
            player.CardsInHand.Add(deckOfCards._redCards[t]);
            int f = random.Next(1, 5);
            player.CardsInHand.Add(deckOfCards._greenCards[f]);
            int l = random.Next(1, 5);
            player.CardsInHand.Add(deckOfCards._whiteCards[l]);

        }
    }
}
