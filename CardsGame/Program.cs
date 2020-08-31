using System;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {

            PlayerDeckOfCards playerDeckOfCards = new PlayerDeckOfCards();
            DeckOfCards d1 = new DeckOfCards();
            d1.cardInitializer();
            //Player player1 = new Player(d1);
            playerDeckOfCards.CardsDealer(d1,player1);
            for (int i = 0; i < player1.CardsInHand.Count; i++)
            {
                int cardNumber = player1.CardsInHand[i].Number;
                string cardColor = player1.CardsInHand[i].Color;
                Console.WriteLine($"The card number is {cardNumber} and the color is {cardColor}.");

            }

        }
    } 
}
