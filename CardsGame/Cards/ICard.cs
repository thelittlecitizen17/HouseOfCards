using System;
using System.Collections.Generic;
using System.Text;

namespace CardsGame
{
    interface ICard
    {
        string Color { get; set; }
        int Number { get; set; }
    }
}
