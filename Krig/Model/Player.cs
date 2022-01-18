
namespace Krig.Model
{
    internal class Player
    {
        private string _name;
        private bool _human;
        private int _points;

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
