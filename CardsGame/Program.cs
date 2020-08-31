using System;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            PlayerDeckOfCards playerDeckOfCards = new PlayerDeckOfCards();
            DeckOfCards d1 = new DeckOfCards();
            d1.cardInitializer();
            playerDeckOfCards.CardsDealer(d1,player1);
            for (int i = 0; i < player1.cardDesk.Count; i++)
            {
                int cardNumber = player1.cardDesk[i].Number;
                string cardColor = player1.cardDesk[i].Color;
                Console.WriteLine($"The card number is {cardNumber} and the color is {cardColor}.");

            }

        }
    } 
}
