using System;
using System.Collections.Generic;
using System.Text;

namespace CardsGame
{
    class BlueCard : ICard
    {
        public string Color { get ;set; }
        public int Number { get; set ; }

        public BlueCard(int number)
        {
            Color = "Blue";
            Number = number;
        }
    }
}
