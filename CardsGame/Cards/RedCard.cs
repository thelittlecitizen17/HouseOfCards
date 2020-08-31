using System;
using System.Collections.Generic;
using System.Text;

namespace CardsGame
{
    class RedCard:ICard
    {
        public string Color { get; set; }
        public int Number { get; set; }

        public RedCard(int number)
        {
            Color = "Red";
            Number = number;
        }
    }
}
