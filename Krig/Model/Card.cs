﻿using Krig.Enums;

namespace Krig.Model
{
    internal class Card
    {
        // _name er via ENUM også dens værdi.
        private Names _name;
        private Color _color;

        internal Names name
        {
            get { return _name; }
            set { _name = value; }
        }

        internal Color color
        {
            get { return _color; }
            set { _color = value; }
        }

    }
}
