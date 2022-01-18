using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Krig.Model;
using Krig.Enums;

namespace Krig.Control
{
    internal class InitializeDeck
    {
        internal InitializeDeck()
        {

        }

        internal Deck go()
        {
            Deck deck = new();
            
            for (Color color = Color.Spar; color <= Color.Ruder; color++ )
            {
                for ( Names name = Names.En; name <= Names.Konge; name++)
                {
                    Card card = new();
                    card.color = color;
                    card.name = name;
                    deck.cards.Add(card);
                }
            }

            return deck;
        }
    }
}
