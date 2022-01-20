using System.Collections.Generic;

namespace Krig.Model
{
    internal class Deck
    {
        // Er lavet som en liste af Card, da jeg under initialiseringen skal kunne gå ind i listen
        // og tage et tilfældigt kort ud til en spiller bunke og fjerne det herfra bagefter.
        private List<Card> _cards = new List<Card>();

        internal List<Card> cards
        {
            get { return _cards; }
            set { _cards = value; }
        }
    }
}
