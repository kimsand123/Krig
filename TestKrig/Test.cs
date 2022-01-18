using System;
using Krig.Control;
using Krig.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestKrig
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void TestDeckInitializing()
        {
            InitializeDeck initialize = new();
            Deck deck = initialize.go();

            foreach (Card card in deck.cards)
            {
                Console.WriteLine("Kulør: {0}", card.color);
                Console.WriteLine("Navn: {0}", card.name.ToString());
            }
        }
    }
}
