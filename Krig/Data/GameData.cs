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

        // Skaber et spil kort med 52 kort, 4 kulører med kort af værdi fra Es - Konge.
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
            // sætter antal kort/runder på baggrund af hvor mange kort der er skabt.
            _nrOfCardsLeft = _originalDeck.cards.Count / 2;
        }

        // Fordeler kortene ud på de 2 spilleres kort stack.
        // Kør loopet antal kort / 2 gange, da der bliver taget 2 kort i hvert loop.
        internal void dealCards()
        {
            for (int counter = 0; counter < _nrOfCardsLeft; counter++)
            {
                _player1Deck.cards.Push(dealCardFromOriginalDeck());
                _player2Deck.cards.Push(dealCardFromOriginalDeck());
            }
        }

        // kopierer et tilfældigt kort i original Kort bunken, som er af en variabel formindskende størrelse.
        // kopierer det sidste kort i bunken ind på det valgte korts plads.
        // fjerner det sidste kort i bunken


        private Card dealCardFromOriginalDeck()
        {
            // nr på sidst kort i bunken. Ændrer sig alt efter hvor mange kort der er tilbage i bunken.
            int lastCardNr = _originalDeck.cards.Count - 1;
            int cardNr = randomizer(lastCardNr);

            Card dealtCard = _originalDeck.cards[cardNr];

            _originalDeck.cards[cardNr] = _originalDeck.cards[lastCardNr];
            _originalDeck.cards.RemoveAt(lastCardNr);

            return dealtCard;
        }

        // Bruges til at lave et tilfældigt tal mellem 0 og nummeret på sidste kort i bunken.
        private int randomizer(int nr)
        {
            if (nr != 0)
            {
                // Så tæt på ægte randomisering man kan komme i C#. Normal Random bruger kun CPU clock til at skabe tal
                // RandomNumberGenerator bruger også andre skiftende parametre fra hardwaren.
                return RandomNumberGenerator.GetInt32(0, nr);
            }
            return 0;
        }
    }
}
