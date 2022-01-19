using System;
using System.Runtime.CompilerServices;
using System.Text;
using Krig.Control;
using Krig.DataAccesLayer;
using Krig.Enums;
using Krig.Model;
using Krig.Service;
using Krig.View;

[assembly: InternalsVisibleTo("TestKrig")]

namespace Krig
{
    class Program
    {
        static void Main(string[] args)
        {
            new GameCTL().run();
            /*Renderer renderer = new();
            StringBuilder screen = renderer.createGameScreen(5, 5, 20, new Card() {color = Color.Spar, name = Names.Konge},
                new Card() {color = Color.Ruder, name = Names.Knægt}, 2);
            renderer.drawScreen(screen);*/
        }


    }
}
