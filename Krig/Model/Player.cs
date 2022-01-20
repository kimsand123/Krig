namespace Krig.Model
{
    internal class Player
    {
        private int _playerNumber;
        private string _name;
        private bool _human; // bliver ikke brugt til noget, men kunne være en go attribut hvis det skulle udvides.
        private int _points;
        private int _pointsFromRound; // pointsFromRound bruges af Renderer til at vurdere hvor der skal skrives "vundet". Bliver reset mellem hvert korttræk
        private Card _cardDrawn; // Bliver brugt så Renderer kan vise den korrekte kort tekst.
        // private PlayerDeck _playerDeck;

        // En spiller burde have sin egen playerdeck, men det er ikke lavet sådan.
        // Til denne lille demo, bliver det ikke lavet om.

        /*internal PlayerDeck playerDeck
        {
            get { return _playerDeck; }
            set { _playerDeck = value; }
        }*/

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
