using CardsGame;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fireworks
{
    public class PlayersManager
    {
        public List<Player> AllPlayers;
        public PlayersManager()
        {
            AllPlayers = new List<Player>();
        }

        public void AddPlayers(List<Player> players)
        {
            AllPlayers.AddRange(players);
        }

        public void MakeAMove()
        {
            // Gets Random Option from "GameMoves" and implements it
        }
    }
}
