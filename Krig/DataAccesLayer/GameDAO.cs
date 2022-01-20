using Krig.Model;
using Krig.Data;

namespace Krig.DataAccesLayer
{
    internal class GameDAO
    {
        private GameData _gameData;

        // GameDAO initialiserer data i GameData
        internal GameDAO(ref GameData gameData)
        {
            _gameData = gameData;
            _gameData.createOriginalDeck();
            _gameData.dealCards();
        }

        internal int nrOfElementsInPlayerDeck1()
        {
            return _gameData.player1Deck.cards.Count;
        }

        internal int nrOfElementsInPlayerDeck2()
        {
            return _gameData.player2Deck.cards.Count;
        }

        internal int getNumberOfCardsLeft()
        {
            return _gameData.nrOfCardsLeft;
        }

        // nedskriver antal kort/runder
        internal void decreaseNumberOfCardsLeft()
        {
            _gameData.nrOfCardsLeft = _gameData.nrOfCardsLeft - 1;
        }

        // trækker kort i den relevante spillers kortstack.
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
