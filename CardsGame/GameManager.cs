using System;
using System.Collections.Generic;
using System.Text;

namespace CardsGame
{
    public class GameManager
    {
        private readonly Random random = new Random();
        private List<Player> _allPlayers;
        private GameStatus _gameStatus;
        private BuildPlayersDeck _buildPlayersDeck;
        private DeckOfCards _deck;

        public GameManager(List<Player> allPlayers)
        {
            _allPlayers = allPlayers;
            _gameStatus = new GameStatus();
            _buildPlayersDeck = new BuildPlayersDeck();
        }

        public void GiveEachPlayerCards()
        {
            foreach (var player in _allPlayers)
            {
                _buildPlayersDeck.CardsDealer(_deck, player);
            }
        }

        public Player PickPlayerToPlay()
        {
            return _allPlayers[random.Next(0, _allPlayers.Count)]; //Chooses a random player to make a move
        }

        public void StartGame()
        {

        }

        

    }
}
