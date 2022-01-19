using Krig.Model;
using Krig.Data;

namespace Krig.DataAccesLayer
{
    internal class GameDAO
    {
        private GameData _gameData;

        internal GameDAO(ref GameData gameData)
        {
            _gameData = gameData;
            _gameData.createOriginalDeck();
            _gameData.dealCards();
        }

        internal int elementsInPlayerDeck1()
        {
            return _gameData.player1Deck.cards.Count;
        }

        internal int elementsInPlayerDeck2()
        {
            return _gameData.player2Deck.cards.Count;
        }

        internal int getNumberOfCardsLeft()
        {
            return _gameData.nrOfCardsLeft;
        }

        internal void decreaseNumberOfCardsLeft()
        {
            _gameData.nrOfCardsLeft = _gameData.nrOfCardsLeft - 1;
        }

        internal void drawCard(ref Player player)
        {
            switch (player.playerNumber)
            {
                case 1:
                    player.cardDrawn = _gameData.player1Deck.cards.Pop();
                    break;
                case 2:
                    player.cardDrawn = _gameData.player2Deck.cards.Pop();
                    break;
            }
        }
    }
}
