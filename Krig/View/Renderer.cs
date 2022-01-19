using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Krig.Model;

namespace Krig.View
{
    internal class Renderer
    {
        internal Renderer()
        {

        }

        internal StringBuilder createGameScreen(int pointsP1, int pointsP2, int cardsLeft, Card cardP1, Card cardP2, int playerWon)
        {
            // Screen er 52 * lang
            StringBuilder screen = new();
            int card1TextLength = cardP1.color.ToString().Length + cardP1.color.ToString().Length;
            int card2TextLength = cardP2.color.ToString().Length + cardP2.color.ToString().Length;

            screen.Append("*****************************************************\n");

            if (playerWon == 1)
            {
                screen.Append("* Kort tilbage: ").Append(cardsLeft).Append(tab(37 - (16 + cardsLeft.ToString().Length))).Append("Vundet").Append(tab(7));
            }
             else
             {
                 screen.Append("* Kort tilbage: ").Append(cardsLeft)
                     .Append(tab(51 - (16 + cardsLeft.ToString().Length)));
             }
             screen.Append("*\n");

            screen.Append("* H A L. ").Append(pointsP1).Append(" point").Append(tab(23 - (15 + pointsP1.ToString().Length)))
                .Append("Spillet kort: ").Append(cardP1.color).Append(" ").Append(cardP1.name)
                .Append(tab(25 - (15 + card1TextLength))).Append(" *\n");

            screen.Append("*                                                   *\n");
            screen.Append("*                                                   *\n");

            screen.Append("* Menneske. ").Append(pointsP2).Append(" point").Append(tab(22 - (17 + pointsP2.ToString().Length)))
                .Append("Spillet kort: ").Append(cardP2.color).Append(" ").Append(cardP2.name)
                .Append(tab(25 - (15 + card2TextLength))).Append(" *\n");


            return screen;
        }

        internal StringBuilder createWonGameScreen(int points, int player)
        {
            StringBuilder screen = new();
            screen.Append("Spiller ").Append(player).Append(" vandt med ").Append(points).Append(" point.");
            return screen;
        }

        private string tab(int nrOfSpaces)
        {
            string spaces = "";
            for (int counter = 0; counter <= nrOfSpaces; counter++)
            {
                spaces = spaces + " ";
            }

            return spaces;
        }

        internal void drawScreen(StringBuilder screen)
        {
            Console.Clear();
            Console.WriteLine(screen);
            Console.WriteLine("Tryk på Enter for at trække næste kort");
            Console.Read();
        }

        


    }
}
