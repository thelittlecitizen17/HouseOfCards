using System;
using System.Collections.Generic;
using System.Text;

namespace CardsGame
{
    public interface ICard
    {
        string Color { get; set; }
        int Number { get; set; }
    }
}
