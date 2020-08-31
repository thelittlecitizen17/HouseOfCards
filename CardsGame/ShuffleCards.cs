using System;
using System.Collections.Generic;
using System.Text;

namespace CardsGame
{
    public static class ShuffleCards
    {
        public static void Shuffle<T>(this IList<T> list, Random random)
        {
            for (var i = 0; i < list.Count; i++)
            {
                var temp = list[i];
                var index = random.Next(0, list.Count);
                list[i] = list[index];
                list[index] = temp;
            }
        }
    }
}
