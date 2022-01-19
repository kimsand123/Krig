using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Krig.Model;

namespace Krig.Control
{
    internal class GameCTL
    {
        private Deck player1Deck = new();
        private Deck player2Deck = new();
        internal GameCTL()
        {

        }

        internal int run(Deck deck)
        {
            int status = 0;
            // Uddel kort
            uddelKort(deck);





            return status;
        }

        private void uddelKort(Deck deck)
        {
            throw new NotImplementedException();
        }
    }
}
