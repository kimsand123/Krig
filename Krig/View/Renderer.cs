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

        internal StringBuilder createGameScreen(ref Player player1, ref Player player2, int cardsLeft)
        {
            // Screen er 52 * lang
            StringBuilder screen = new();
            int card1TextLength = player1.cardDrawn.color.ToString().Length + player1.cardDrawn.color.ToString().Length;
            int card2TextLength = player2.cardDrawn.color.ToString().Length + player2.cardDrawn.color.ToString().Length;

            screen.Append("*****************************************************\n");

            if (player1.playerWonRound)
            {
                screen.Append("* Kort tilbage: ").Append(cardsLeft).Append(tab(37 - (16 + cardsLeft.ToString().Length))).Append("Vundet").Append(tab(7));
            }
             else
             {
                 screen.Append("* Kort tilbage: ").Append(cardsLeft)
                     .Append(tab(51 - (16 + cardsLeft.ToString().Length)));
             }
             screen.Append("*\n");

            screen.Append("* H A L. ").Append(player1.points).Append(" point").Append(tab(23 - (15 + player1.points.ToString().Length)))
                .Append("Spillet kort: ").Append(player1.cardDrawn.color).Append(" ").Append(player1.cardDrawn.name)
                .Append(tab(25 - (15 + card1TextLength))).Append(" *\n");

            screen.Append("*                                                   *\n");
            screen.Append("*                                                   *\n");

            screen.Append("* Menneske. ").Append(player2.points).Append(" point").Append(tab(22 - (17 + player2.points.ToString().Length)))
                .Append("Spillet kort: ").Append(player2.cardDrawn.color).Append(" ").Append(player2.cardDrawn.name)
                .Append(tab(25 - (15 + card2TextLength))).Append(" *\n");


            return screen;
        }

        internal StringBuilder createWonGameScreen(Player player)
        {
            StringBuilder screen = new();

            // Hvis spillernummeret er 3 er kampen endt uafgjort
            if (player.playerNumber != 3)
            {
                screen.Append("Spiller ").Append(player.name).Append(" vandt med ").Append(player.points)
                    .Append(" point.");
            }
            else
            {
                screen.Append("Kampen endte uafgjort mellem ").Append(player.name).Append(" med ").Append(player.points)
                    .Append(" point.");
            }
            return screen;
        }

        private string tab(int nrOfSpaces)
        {
            string spaces = "";
            for (int counter = 0; counter <= nrOfSpaces; counter++)
            {
                spaces += " ";
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
