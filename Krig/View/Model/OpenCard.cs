using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Krig.Enums;
using Krig.Model;

namespace Krig.View.Model
{
    internal class OpenCard
    {
        private int _xPosOpenCardImage;
        private int _yPosOpenCardImage;

        private Dictionary<Names, string[]> namesGraphics = new();
        private Dictionary<Color, string[]> colorGraphics = new();

        private string[] _openCardImage = new[]{"*******************" +
                                                "*                 *" +
                                                "*                 *" +
                                                "*                 *" +
                                                "*                 *" +
                                                "*                 *" +
                                                "*                 *" +
                                                "*                 *" +
                                                "*                 *" +
                                                "*                 *" +
                                                "*                 *" +
                                                "*                 *" +
                                                "*                 *" +
                                                "*                 *" +
                                                "*                 *" +
                                                "*                 *" +
                                                "*                 *" +
                                                "*                 *" +
                                                "*                 *" +
                                                "*                 *" +
                                                "*******************"
        };

        internal OpenCard()
        {
            initalizeDataStructure();
        }

        private void initalizeDataStructure()
        {
            namesGraphics.Add(Names.En, new string[]{
                "   *  " +
                "  **  " +
                " * *  " +
                "*  *  " +
                "   *  " +
                "   *  " +
                "   *  " +
                "   *  " +
                "******"});
            namesGraphics.Add(Names.To, new string[]{
                " **** " +
                "*    *" +
                "     *" +
                "    * " +
                "   *  " +
                "  *   " +
                " *    " +
                "*     " +
                "******"});
            namesGraphics.Add(Names.Tre, new string[]{
                " **** " +
                "*    *" +
                "     *" +
                "   ** " +
                "     *" +
                "     *" +
                "     *" +
                "*    *" +
                " **** "});
            namesGraphics.Add(Names.Fire, new string[]{
                "   ***" +
                "  *  *" +
                " *   *" +
                "******" +
                "     *" +
                "     *" +
                "     *" +
                "     *" +
                "     *"});
            namesGraphics.Add(Names.Fem, new string[]{
                "******" +
                "*     " +
                "*     " +
                "***** " +
                "     *" +
                "     *" +
                "     *" +
                "*    *" +
                " **** "});
            namesGraphics.Add(Names.Seks, new string[]{
                "    **" +
                "  *   " +
                " *    " +
                "***** " +
                "*    *" +
                "*    *" +
                "*    *" +
                "*    *" +
                " **** "});
            namesGraphics.Add(Names.Syv, new string[]{
                "******" +
                "     *" +
                "     *" +
                "    * " +
                "   *  " +
                "  *   " +
                " *    " +
                "*     " +
                "*     "});
            namesGraphics.Add(Names.Otte, new string[]{
                " **** " +
                "*    *" +
                "*    *" +
                " **** " +
                "*    *" +
                "*    *" +
                "*    *" +
                "*    *" +
                " **** "});
            namesGraphics.Add(Names.Ni, new string[]{
                " **** " +
                "*    *" +
                "*    *" +
                " *****" +
                "    * " +
                "   *  " +
                "  *   " +
                " *    " +
                "*     "});
            namesGraphics.Add(Names.Ti, new string[]{
                "*  ** " +
                "* *  *" +
                "* *  *" +
                "* *  *" +
                "* *  *" +
                "* *  *" +
                "* *  *" +
                "* *  *" +
                "*  ** "});
            namesGraphics.Add(Names.Knægt, new string[]{                                                
                " *****" +
                "     *" +
                "     *" +
                "     *" +
                "     *" +
                "     *" +
                "     *" +
                "*    *" +
                " *****"});
            namesGraphics.Add(Names.Dame, new string[]{
                " **** " +
                "*    *" +
                "*    *" +
                "*    *" +
                "* *  *" +
                "* *  *" +
                "*  * *" +
                " **** " +
                "     *"});
            namesGraphics.Add(Names.Konge, new string[]{
                "*    *" +
                "*  *  " +
                "* *   " +
                "**    " +
                "**    " +
                "* *   " +
                "*  *  " +
                "*   * " +
                "*    *"});

            colorGraphics.Add(Color.Spar, new string[]
            {
                "    *    " +
                "   ***   " +
                "  *****  " +
                "*********" +
                "*********" +
                "  *****  " +
                "   ***   " +
                "    *    " +
                "  *****  "
            });

            colorGraphics.Add(Color.Kloer, new string[]
            {
                "    *    " +
                "   ***   " +
                "    *    " +
                " *  *  * " +
                "*********" +
                " *  *  * " +
                "    *    " +
                "   ***   " +
                "*********"
            });

            colorGraphics.Add(Color.Hjerter, new string[]
            {
                "  *   *  " +
                " *** *** " +
                "*********" +
                "*********" +
                " ******* " +
                "  *****  " +
                "   ***   " +
                "    *    " +
                "         "
            });

            colorGraphics.Add(Color.Ruder, new string[]
            {
                "    *    " +
                "   ***   " +
                "  *****  " +
                " ******* " +
                "*********" +
                " ******* " +
                "  *****  " +
                "   ***   " +
                "    *    "
            });

        }

        


        internal int XPosClosedDeckImageP1
        {
            get { return _xPosOpenCardImage; }
            set { _xPosOpenCardImage = value; }
        }

        internal int YPosClosedDeckImageP1
        {
            get { return _yPosOpenCardImage; }
            set { _yPosOpenCardImage = value; }
        }

        internal string[] Image(Card card)
        {
            // For hver 19 skiftes der linje på kortet 0-18 1. linje
            // For card.name skiftes der linje for hver 6. 0-5 1. linje i navn

            string[] cardImage = new string[_openCardImage.Length];
            cardImage = _openCardImage;

            for (int cardPos = 0; cardPos <_openCardImage.Length ; cardPos++){
                if (cardPos == 21)
                {
                    for (int namePos = 0; namePos < namesGraphics[card.name].Length; namePos++)
                    {
                        if (namePos % 6 == 0)
                        {
                            break;
                        }


                    }
                }
            }


            return cardImage;
        }
    }
}
