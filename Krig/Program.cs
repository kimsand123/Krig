using System;
using System.Runtime.CompilerServices;
using System.Text;
using Krig.Control;
using Krig.Enums;
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
            StringBuilder screen = renderer.createGameScreen(10, 5, 20, new Card() {color = Color.Hjerter, name = Names.Konge},
                new Card() {color = Color.Ruder, name = Names.Knægt}, 2);
            renderer.drawScreen(screen);
        }


    }
}
