using System;
using System.Runtime.CompilerServices;
using Krig.Control;
using Krig.Model;
using Krig.View;

[assembly: InternalsVisibleTo("TestKrig")]

namespace Krig
{
    class Program
    {
        static void Main(string[] args)
        {
            Renderer renderer = new();
            string play = "j";
            // Ydre gameloop. Start, stop og fortsæt spil.
            while (play=="j" || play=="J")
            {
                Player player1 = new() { human = true, name = "H A L.", playerNumber = 1, points = 0 };
                Player player2 = new() { human = false, name = "Menneske.", playerNumber = 2, points = 0 };
                new GameCTL().run(player1, player2);
                Console.Write("Vil du spille igen j/n: ");
                play = Console.ReadLine();
            }
        }
    }
}
