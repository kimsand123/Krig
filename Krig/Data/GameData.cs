using System.Security.Cryptography;
using Krig.Enums;
using Krig.Model;

namespace Krig.Data
{
    internal class GameData
    {
        private Deck _originalDeck = new();
        private PlayerDeck _player1Deck = new();
        private PlayerDeck _player2Deck = new();

        private int _nrOfCardsLeft = 0;

        internal int nrOfCardsLeft
        {
            get { return _nrOfCardsLeft; }
            set { _nrOfCardsLeft = value; }
        }

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

        internal GameData()
        {
            
        }

        internal void createOriginalDeck()
        {
            for (Color color = Color.Spar; color <= Color.Ruder; color++)
            {
                for (Names name = Names.Es; name <= Names.Konge; name++)
                {
                    Card card = new();
                    card.color = color;
                    card.name = name;
                    _originalDeck.cards.Add(card);
                }
            }
            _nrOfCardsLeft = _originalDeck.cards.Count / 2;
        }

        internal void dealCards()
        {
            for (int counter = 0; counter < _nrOfCardsLeft; counter++)
            {
                _player1Deck.cards.Push(dealCardFromOriginalDeck());
                _player2Deck.cards.Push(dealCardFromOriginalDeck());
            }
        }

        private Card dealCardFromOriginalDeck()
        {
            int lastCardNr = _originalDeck.cards.Count - 1;
            int cardNr = randomizer(lastCardNr);

            Card dealtCard = _originalDeck.cards[cardNr];

            _originalDeck.cards[cardNr] = _originalDeck.cards[lastCardNr];
            _originalDeck.cards.RemoveAt(lastCardNr);

            return dealtCard;
        }

        private int randomizer(int nr)
        {
            if (nr != 0)
            {
                return RandomNumberGenerator.GetInt32(0, nr);
            }

            return 0;
        }


    }
}
