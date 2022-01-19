/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Krig.DataAccesLayer;
using Krig.Enums;
using Krig.Model;

namespace Krig.Control
{
    internal class DeckCTL
    {
        private PlayerDeck _player1Deck = new();
        private PlayerDeck _player2Deck = new();
        private GameDAO _gameDAO = new();

        private int _nrOfCards = 0;

        internal DeckCTL(GameDAO gameDao)
        {
            _gameDAO = gameDao;
        }

        internal void dealCards()
        {
            for (int counter = 0; counter < _nrOfCards/2; counter++)
            {
                _player1Deck.cards.Push(dealCard());
                _player2Deck.cards.Push(dealCard());
            }

            _gameDAO.player1Deck = _player1Deck;
            _gameDAO.player2Deck = _player2Deck;
        }

        private Card dealCard()
        {
            int lastCardNr = _gameDAO.originalDeck.cards.Count - 1;
            int cardNr = randomizer(lastCardNr);

            Card dealtCard = _gameDAO.originalDeck.cards[cardNr];

            _gameDAO.originalDeck.cards[cardNr] = _gameDAO.originalDeck.cards[lastCardNr];
            _gameDAO.originalDeck.cards.Insert(lastCardNr, dealtCard);

            _gameDAO.originalDeck.cards.RemoveAt(lastCardNr);

            return dealtCard;
        }

        private int randomizer(int nr)
        {
            return RandomNumberGenerator.GetInt32(0, nr);
        }
    }
}*/