using System;
using System.Collections.Generic;
using System.Text;

namespace CardsGame
{
    class DeckOfCards
    {
        public List<ICard> CardsDeck = new List<ICard>();
        public List<ICard> _yellowCards = new List<ICard>();
        public List<ICard> _blueCards = new List<ICard>();
        public List<ICard> _greenCards = new List<ICard>();
        public List<ICard> _whiteCards = new List<ICard>();
        public List<ICard> _redCards = new List<ICard>();

        public DeckOfCards()
        {
            _yellowCards = new List<ICard>();
            _blueCards = new List<ICard>();
            _greenCards = new List<ICard>();
            _whiteCards = new List<ICard>();
            _redCards = new List<ICard>();
            
        }
        public void cardInitializer()
        {
            yellowDeckInitializer();
            redDeckInitializer();
            whiteDeckInitializer();
            blueDeckInitializer();
            greenDeckInitializer();
              
        }
        private void yellowDeckInitializer()
        {
            ICard card1 = new YellowCard(1);
            ICard card2 = new YellowCard(2);
            ICard card3 = new YellowCard(3);
            ICard card4 = new YellowCard(4);
            ICard card5 = new YellowCard(5);
            ICard card6 = new YellowCard(1);
            ICard card7 = new YellowCard(2);
            ICard card8 = new YellowCard(3);
            ICard card9 = new YellowCard(4);
            ICard card10 = new YellowCard(5);

            _yellowCards.Add(card1);
            _yellowCards.Add(card2);
            _yellowCards.Add(card3);
            _yellowCards.Add(card4);
            _yellowCards.Add(card5);
            _yellowCards.Add(card6);
            _yellowCards.Add(card7);
            _yellowCards.Add(card8);
            _yellowCards.Add(card9);
            _yellowCards.Add(card10);
        }
        private void whiteDeckInitializer()
        {
            ICard card1 = new WhiteCard(1);
            ICard card2 = new WhiteCard(2);
            ICard card3 = new WhiteCard(3);
            ICard card4 = new WhiteCard(4);
            ICard card5 = new WhiteCard(5);
            ICard card6 = new WhiteCard(6);
            ICard card7 = new WhiteCard(7);
            ICard card8 = new WhiteCard(8);
            ICard card9 = new WhiteCard(9);
            ICard card10 = new WhiteCard(10);

            _whiteCards.Add(card1);
            _whiteCards.Add(card2);
            _whiteCards.Add(card3);
            _whiteCards.Add(card4);
            _whiteCards.Add(card5);
            _whiteCards.Add(card6);
            _whiteCards.Add(card7);
            _whiteCards.Add(card8);
            _whiteCards.Add(card9);
            _whiteCards.Add(card10);
        }
        private void blueDeckInitializer()
        {
            ICard card1 = new BlueCard(1);
            ICard card2 = new BlueCard(2);
            ICard card3 = new BlueCard(3);
            ICard card4 = new BlueCard(4);
            ICard card5 = new BlueCard(5);
            ICard card6 = new BlueCard(6);
            ICard card7 = new BlueCard(7);
            ICard card8 = new BlueCard(8);
            ICard card9 = new BlueCard(9);
            ICard card10 = new BlueCard(10);

            _blueCards.Add(card1);
            _blueCards.Add(card2);
            _blueCards.Add(card3);
            _blueCards.Add(card4);
            _blueCards.Add(card5);
            _blueCards.Add(card6);
            _blueCards.Add(card7);
            _blueCards.Add(card8);
            _blueCards.Add(card9);
            _blueCards.Add(card10);
        }
        private void redDeckInitializer()
        {
            ICard card1 = new RedCard(1);
            ICard card2 = new RedCard(2);
            ICard card3 = new RedCard(3);
            ICard card4 = new RedCard(4);
            ICard card5 = new RedCard(5);
            ICard card6 = new RedCard(6);
            ICard card7 = new RedCard(7);
            ICard card8 = new RedCard(8);
            ICard card9 = new RedCard(9);
            ICard card10 = new RedCard(10);

            _redCards.Add(card1);
            _redCards.Add(card2);
            _redCards.Add(card3);
            _redCards.Add(card4);
            _redCards.Add(card5);
            _redCards.Add(card6);
            _redCards.Add(card7);
            _redCards.Add(card8);
            _redCards.Add(card9);
            _redCards.Add(card10);
        }
        private void greenDeckInitializer()
        {
            ICard card1 = new GreenCard(1);
            ICard card2 = new GreenCard(2);
            ICard card3 = new GreenCard(3);
            ICard card4 = new GreenCard(4);
            ICard card5 = new GreenCard(5);
            ICard card6 = new GreenCard(6);
            ICard card7 = new GreenCard(7);
            ICard card8 = new GreenCard(8);
            ICard card9 = new GreenCard(9);
            ICard card10 = new GreenCard(10);

            _greenCards.Add(card1);
            _greenCards.Add(card2);
            _greenCards.Add(card3);
            _greenCards.Add(card4);
            _greenCards.Add(card5);
            _greenCards.Add(card6);
            _greenCards.Add(card7);
            _greenCards.Add(card8);
            _greenCards.Add(card9);
            _greenCards.Add(card10);
        }


    }
}
