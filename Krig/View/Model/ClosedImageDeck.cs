using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krig.Model.View
{
    internal class ClosedImageDeck
    {
        private int _xPosClosedDeckImage;
        private int _yPosClosedDeckImage;
        private string[] _closedDeckImage = new[]{"**********" +
                                                  "**      **" +
                                                  "* *    * *" +
                                                  "*  *  *  *" +
                                                  "*   **   *" +
                                                  "*  *  *  *" +
                                                  "* *    * *" +
                                                  "**      **" +
                                                  "**********"
        };

        internal int XPosClosedDeckImageP1
        {
            get { return _xPosClosedDeckImage; }
            set { _xPosClosedDeckImage = value; }
        }

        internal int YPosClosedDeckImageP1
        {
            get { return _yPosClosedDeckImage; }
            set { _yPosClosedDeckImage = value; }
        }

    }
}
