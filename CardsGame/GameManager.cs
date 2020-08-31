using System;
using System.Collections.Generic;
using System.Text;

namespace CardsGame
{
    public class GameManager
    {
        private List<Player> _allPlayers;
        private GameStatus _gameStatus;

        public GameManager(List<Player> allPlayers)
        {
            _allPlayers = allPlayers;
            _gameStatus = new GameStatus();
        }

        public void GiveEachPlayerCard()
        {

        }

    }
}
