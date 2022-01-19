using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Krig.DataAccesLayer;
using Krig.Enums;
using Krig.Model;

namespace Krig.Control
{
    internal class InitializeGameCTL
    {
        private GameDAO _gameDAO = new();

        internal GameDAO gameDao
        {
            get { return _gameDAO; }
            set { _gameDAO = value; }
        }
        internal InitializeGameCTL()
        {
            
        }

        internal void cards()
        {
            Deck originalDeck = new();
            for (Color color = Color.Spar; color <= Color.Ruder; color++)
            {
                for (Names name = Names.En; name <= Names.Konge; name++)
                {
                    Card card = new();
                    card.color = color;
                    card.name = name;
                    originalDeck.cards.Add(card);
                }
            }
            _nrOfCards = _originalDeck.cards.Count;
        }
    }
}
