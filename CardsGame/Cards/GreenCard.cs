using System;
using System.Collections.Generic;
using System.Text;

namespace CardsGame
{
    class GreenCard:ICard
    {
        public string Color { get; set; }
        public int Number { get; set; }

        public GreenCard(int number)
        {
            Color = "Green";
            Number = number;
        }
    }
}
