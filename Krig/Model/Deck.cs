using System.Collections.Generic;

namespace Krig.Model
{
    internal class Deck
    {
        private List<Card> _cards = new List<Card>();

        internal List<Card> cards
        {
            get { return _cards; }
            set { _cards = value; }
        }
    }
}
