using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Krig.Model;

namespace Krig.DataAccesLayer
{
    internal class DeckDAO
    {
        private Deck _originalDeck = new();
        private PlayerDeck _player1Deck = new();
        private PlayerDeck _player2Deck = new();

        internal PlayerDeck player1Deck
        {
            get { return _player1Deck; }
            set { _player1Deck = value; }
        }

        internal PlayerDeck player2Deck
        {
            get { return _player2Deck; }
            set { _player2Deck = value; }
        }

        internal Deck originalDeck
        {
            get { return _originalDeck; }
            set { _originalDeck = value; }
        }

        internal DeckDAO()
        {
        }

        internal int elementsInPlayerDeck1()
        {
            return _player1Deck.cards.Count;
        }

        internal int elementsInPlayerDeck2()
        {
            return _player2Deck.cards.Count;
        }

        internal Card drawCard(int playerNr)
        {
            switch (playerNr)
            {
                case 1:
                    return player1Deck.cards.Pop();
                case 2:
                    return player2Deck.cards.Pop();
                default:
                    return null;
            }
        }
    }
}
