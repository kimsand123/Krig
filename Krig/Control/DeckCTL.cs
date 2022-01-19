using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Krig.Enums;
using Krig.Model;

namespace Krig.Control
{
    internal class DeckCTL
    {
        private PlayerDeck _player1Deck = new();
        private PlayerDeck _player2Deck = new();
        private Deck _originalDeck = new();

        private int _nrOfCards = 0;

        internal void dealCards()
        {
            // metode til at uddele kortene til de to playerdecks
            Card dealtCard = new();

            for (int counter = 0; counter < _nrOfCards/2; counter++)
            {
                _player1Deck.cards.Push(dealCard());
                _player2Deck.cards.Push(dealCard());
            }
        }

        private Card dealCard()
        {
            int cardNr = randomizer(_originalDeck.cards.Count - 1);
            int lastCard = _originalDeck.cards.Count - 1;

            Card dealtCard = _originalDeck.cards[cardNr];
            _originalDeck.cards[cardNr] = _originalDeck.cards[lastCard];
            _originalDeck.cards.Insert(lastCard, dealtCard);

            _originalDeck.cards.RemoveAt(lastCard);

            return dealtCard;
        }



       

        private int randomizer(int nr)
        {
            // Random er kun pseudo random. Dette er mere random da den ud over CPU clocken
            // også bruger data fra andre enheder i computeren.

            return RandomNumberGenerator.GetInt32(0, nr);
        }
    }
}