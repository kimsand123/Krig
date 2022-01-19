using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krig.Model
{
    internal class PlayerDeck
    {
        private Stack<Card> _cards = new();

        internal Stack<Card> cards
        {
            get { return _cards; }
            set { _cards = value; }
        }
    }
}
