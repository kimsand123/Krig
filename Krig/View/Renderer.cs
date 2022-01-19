using System;
using System.Text;
using Krig.Model;

namespace Krig.View
{
    internal class Renderer
    {
        private string _topLine = "********************************************************\n";
        private int _lMargin = 1;

        internal Renderer()
        {

        }

        internal StringBuilder createGameScreen(ref Player player1, ref Player player2, int cardsLeft)
        {
            StringBuilder screen = new();
            int lengthOfUsableArea = _topLine.Length - 2;

            // Længde på kort tekst for spiller 1 og spiller 2
            int card1TextLength = player1.cardDrawn.color.ToString().Length + player1.cardDrawn.name.ToString().Length;
            int card2TextLength = player2.cardDrawn.color.ToString().Length + player2.cardDrawn.name.ToString().Length;

            // Toplinje
            screen.Append(_topLine);

            // Højre og venstre side.
            screen.Append("*").Append(tab(lengthOfUsableArea - 1)).Append("*\n");

            // Antal Omgange tilbage
            string omgangeTekst = "Omgange tilbage: ";

            screen.Append("*").Append(tab(_lMargin)).Append(omgangeTekst).Append(cardsLeft)
                .Append(tab(lengthOfUsableArea - (omgangeTekst.Length + cardsLeft.ToString().Length + 2)))
                .Append("*\n");

            screen.Append("*").Append(tab(lengthOfUsableArea - 1)).Append("*\n");

            // Spiller 1 linje
            screen.Append("*").Append(tab(_lMargin))
                .Append(player1.name).Append(" ").Append(player1.points).Append(" point")
                //                             1. halvdel af skærmen - (faste char + 1 + variable char)  + 1 pga. den anden del af teksten er lang mangler 1 space.
                .Append(tab(lengthOfUsableArea / 2 - (15 + player1.points.ToString().Length)))
                .Append("Spillet kort: ")
                .Append(player1.cardDrawn.color).Append(" ")
                .Append(player1.cardDrawn.name)
                //                             2. halvdel af skærmen - (faste char - 1 + variable char) - 1 pga. Der nu er en ekstra plads pga. +1 i linje 44
                .Append(tab(lengthOfUsableArea / 2 - (14 + card1TextLength)))
                .Append("*\n");

            if (player1.pointsFromRound == 2)
            {
                screen.Append("*").Append(tab(_lMargin))
                    .Append(tab(lengthOfUsableArea / 2))
                    .Append("vundet")
                    //                             2. halvdel af skærmen - (faste char + 1 + variable char)  + 1 pga. den anden del af teksten er lang mangler 1 space.
                    .Append(tab(lengthOfUsableArea / 2 - (7)))
                    .Append("*\n");
            }
            else
            {
                screen.Append("*").Append(tab(lengthOfUsableArea - 1)).Append("*\n");
            }

            // Uafgjort
            if (player1.pointsFromRound == player2.pointsFromRound)
            {
                screen.Append("*").Append(tab(_lMargin))
                    .Append(tab(lengthOfUsableArea/2))
                    .Append("uafgjort")
                    //                             2. halvdel af skærmen - (faste char + 1 + variable char)  + 1 pga. den anden del af teksten er lang mangler 1 space.
                    .Append(tab(lengthOfUsableArea / 2 - (9)))
                    .Append("*\n");
            }
            else // almindelig
            {
                screen.Append("*").Append(tab(lengthOfUsableArea - 1)).Append("*\n");
            }

            if(player2.pointsFromRound == 2)
            {
                screen.Append("*").Append(tab(_lMargin))
                    .Append(tab(lengthOfUsableArea / 2))
                    .Append("vundet")
                    //                             2. halvdel af skærmen - (faste char + 1 + variable char)  + 1 pga. den anden del af teksten er lang mangler 1 space.
                    .Append(tab(lengthOfUsableArea / 2 - (7)))
                    .Append("*\n");
            }
            else
            {
                screen.Append("*").Append(tab(lengthOfUsableArea - 1)).Append("*\n");
            }

            // Spiller 1 linje
            screen.Append("*").Append(tab(_lMargin))
                .Append(player1.name).Append(" ").Append(player2.points).Append(" point")
                //                             1. halvdel af skærmen - (faste char + 1 + variable char)  + 1 pga. den anden del af teksten er lang mangler 1 space.
                .Append(tab(lengthOfUsableArea / 2 - (15 + player2.points.ToString().Length)))
                .Append("Spillet kort: ")
                .Append(player2.cardDrawn.color).Append(" ")
                .Append(player2.cardDrawn.name)
                //                             2. halvdel af skærmen - (faste char - 1 + variable char) - 1 pga. Der nu er en ekstra plads pga. +1 i linje 44
                .Append(tab(lengthOfUsableArea / 2 - (14 + card2TextLength)))
                .Append("*\n");

            screen.Append(_topLine);


            return screen;
        }

        internal StringBuilder createWonGameScreen(Player player)
        {
            StringBuilder screen = new();
            int lengthOfUsableArea = _topLine.Length - 2;

            screen.Append(_topLine);
            screen.Append("*").Append(tab(lengthOfUsableArea - 1)).Append("*\n");
            screen.Append("*").Append(tab(lengthOfUsableArea - 1)).Append("*\n");
            screen.Append("*").Append(tab(lengthOfUsableArea - 1)).Append("*\n");



            // Hvis spillernummeret er 3 er kampen endt uafgjort
            if (player.playerNumber != 3)
            {
                int tekstLength = 27 + player.name.Length + player.points.ToString().Length;
                screen.Append("*")
                    .Append(tab(10))
                    .Append("Spiller ").Append(player.name).Append(" vandt med ").Append(player.points).Append(" point.")
                    .Append(tab(lengthOfUsableArea - ((10 + tekstLength))))
                    .Append("*\n");
            }
            else // uafgjort
            {
                int tekstLength = 36;
                screen.Append("*")
                    .Append(tab(10))
                    .Append("Kampen endte uafgjort med ").Append(player.points).Append(" point.")
                    .Append(tab(lengthOfUsableArea - ((10 + tekstLength))))
                    .Append("*\n");
            }

            screen.Append("*").Append(tab(lengthOfUsableArea - 1)).Append("*\n");
            screen.Append("*").Append(tab(lengthOfUsableArea - 1)).Append("*\n");
            screen.Append("*").Append(tab(lengthOfUsableArea - 1)).Append("*\n");
            screen.Append("*").Append(tab(lengthOfUsableArea - 1)).Append("*\n");
            screen.Append(_topLine);

            return screen;
        }

        internal StringBuilder startScreen()
        {
            StringBuilder screen = new();
            screen.Append("\n\n\n\n       Velkommen til krig \n\n\n\n");
            return screen;
        }

        private string tab(int nrOfSpaces)
        {
            string spaces = "";
            for (int counter = 0; counter < nrOfSpaces; counter++)
            {
                spaces = spaces + " ";
            }
            return spaces;
        }



        internal void drawScreen(StringBuilder screen)
        {
            Console.Clear();
            Console.WriteLine(screen);
            Console.WriteLine("Tryk på Enter for at fortsætte");
            Console.ReadLine();
        }
    }
}
