using System;
using System.Collections.Generic;
using System.Text;

namespace CardsGame
{
    class YellowCard:ICard
    {
        public string Color { get; set; }
        public int Number { get; set; }

        public YellowCard(int number)
        {
            Color = "Yellow";
            Number = number;
        }
    }
}
