using System.Collections.Generic;

namespace Krig.Model
{
    internal class PlayerDeck
    {
        // Spiller kort bunken repræsenteres som en Stack da der i spillet skal 
        // fjernes kort fra den ene ende af stakken når man spiller.
        // Dvs. man kan pushe og poppe, og få objektet ud, samt opdatering af datastrukturen
        // i samme operation.
        private Stack<Card> _cards = new();

        internal Stack<Card> cards
        {
            get { return _cards; }
            set { _cards = value; }
        }
    }
}
