using System;
using System.Collections.Generic;
using Krig.Control;
using Krig.Data;
using Krig.DataAccesLayer;
using Krig.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestKrig
{
    [TestClass]
    public class Test
    {
        private GameData gameData;
        private GameDAO gameDAO;
        private Player player1;
        private Player player2;

        [TestInitialize]
        public void initialiseTests()
        {
            gameData = new();
            gameDAO = new(ref gameData);
            gameData.createOriginalDeck();
            gameData.dealCards();
            player1 = new() { human = true, name = "H A L.", playerNumber = 1, points = 0 };
            player2 = new() { human = false, name = "Menneske.", playerNumber = 2, points = 0 };
        }

        [TestMethod]
        public void TestTwoDecksNotAlike()
        {

            List<Card> tmpList = new();

            for (int counter = 0; counter < gameData.player1Deck.cards.Count; counter++)
            {
                tmpList.Add(gameData.player1Deck.cards.Pop());
            }

            for (int counter = 0; counter < gameData.player2Deck.cards.Count; counter++)
            {
                tmpList.Add(gameData.player2Deck.cards.Pop());
            }

            bool stop = false;
            for (int counter = 0; counter < tmpList.Count; counter++)
            {
                for (int restCounter = counter + 1; restCounter < tmpList.Count; restCounter++)
                {
                    if (tmpList[counter].color == tmpList[restCounter].color &&
                        tmpList[counter].name == tmpList[restCounter].name)
                    {
                        stop = true;
                        break;
                    }
                }

                if (stop)
                {
                    break;
                }
            }
            Assert.AreEqual(stop, false);
        }

        [TestMethod]
        public void checkDrawCardsWorksAndNrOfCardsLeftIsUpdated()
        {

            int nrOfCardsLeft = gameDAO.getNumberOfCardsLeft();
            for (int counter = 0; counter < gameDAO.nrOfElementsInPlayerDeck1(); counter++)
            {
                gameDAO.drawCard(ref player1);
                gameDAO.drawCard(ref player2);
                gameDAO.decreaseNumberOfCardsLeft();

                Assert.AreNotEqual(player1.cardDrawn, null);
                Assert.AreNotEqual(player2.cardDrawn, null);
                Assert.AreEqual(gameDAO.getNumberOfCardsLeft(), nrOfCardsLeft - 1 );
                nrOfCardsLeft = gameDAO.getNumberOfCardsLeft();
            }
        }

        [TestMethod]
        public void checkNrOfCards()
        {
            Assert.AreEqual(gameData.nrOfCardsLeft, 26);
        }


    }
}
