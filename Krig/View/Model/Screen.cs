using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krig.Model.View
{
    internal class Screen
    {
        private string[] _screen = new[]
        {
            "************************************************************************************" +
            "*                                                                                  *" +
            "*                                                                                  *" +
            "*                                                                                  *" +
            "*                                                                                  *" +
            "*                                                                                  *" +
            "*                                                                                  *" +
            "*                                                                                  *" +
            "*                                                                                  *" +
            "*                                                                                  *" +
            "*                                                                                  *" +
            "*                                                                                  *" +
            "*                                                                                  *" +
            "*                                                                                  *" +
            "*                                                                                  *" +
            "*                                                                                  *" +
            "*                                                                                  *" +
            "*                                                                                  *" +
            "*                                                                                  *" +
            "*                                                                                  *" +
            "*                                                                                  *" +
            "*                                                                                  *" +
            "*                                                                                  *" +
            "*                                                                                  *" +
            "*                                                                                  *" +
            "*                                                                                  *" +
            "*                                                                                  *" +
            "*                                                                                  *" +
            "*                                                                                  *" +
            "*                                                                                  *" +
            "************************************************************************************"
        };

        internal string[] screen
        {
            get { return _screen; }
            set { _screen = value; }
        }

    }
}
