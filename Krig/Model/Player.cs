
using System.Runtime.InteropServices;

namespace Krig.Model
{
    internal class Player
    {
        private int _playerNumber;
        private string _name;
        private bool _human;
        private int _points;
        private int _pointsFromRound;
        private Card _cardDrawn;
        private PlayerDeck _playerDeck;

        internal PlayerDeck playerDeck
        {
            get { return _playerDeck; }
            set { _playerDeck = value; }
        }

        internal Card cardDrawn
        {
            get { return _cardDrawn; }
            set { _cardDrawn = value; }
        }

        internal int pointsFromRound
        {
            get { return _pointsFromRound; }
            set { _pointsFromRound = value; }
        }

        internal int playerNumber
        {
            get { return _playerNumber; }
            set { _playerNumber = value; }
        }

        internal string name
        {
            get { return _name;}
            set { _name = value; }
        }

        internal bool human
        {
            get { return _human; }
            set { _human = value; }
        }

        internal int points
        {
            get { return _points; }
            set { _points = value; }
        }

    }
}
