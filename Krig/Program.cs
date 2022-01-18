using System;
using System.Runtime.CompilerServices;
using Krig.Control;
using Krig.Enums;
using Krig.Model;
using Krig.View.Model;

[assembly: InternalsVisibleTo("TestKrig")]

namespace Krig
{
    class Program
    {
        static void Main(string[] args)
        {
            OpenCard card = new();
            string[] cardImage = card.Image(new Card() {color = Color.Kloer, name = Names.Ti});
            for (int taller = 0; taller < cardImage.Length; taller++)
            {
                if (taller % 19 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write(cardImage[taller]);
            }

        }


    }
}
