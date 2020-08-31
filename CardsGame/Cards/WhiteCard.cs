using System;
using System.Collections.Generic;
using System.Text;

namespace CardsGame
{
    class WhiteCard:ICard
    {
        public string Color { get; set; }
        public int Number { get; set; }

        public WhiteCard(int number)
        {
            Color = "White";
            Number = number;
        }
    }
}
