using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Krig.DataAccesLayer;
using Krig.Model;
using Krig.Data;
using Krig.View;

namespace Krig.Control
{
    internal class GameCTL
    {
        private GameDAO _gameDAO;
        private Renderer _renderer = new();


        private bool _gameOver = false;


        internal GameCTL()
        {
            GameData gameData = new();
            _gameDAO = new(ref gameData);
        }

        internal void run()
        {
            Player player1 = new() { human = true, name = "H A L.", playerNumber = 1, points = 0 };
            Player player2 = new() { human = false, name = "Menneske.", playerNumber = 2, points = 0 };
            StringBuilder screen;
            screen = _renderer.startScreen();
            _renderer.drawScreen(screen);
            while (!_gameOver)
            {
                _gameDAO.drawCard(ref player1);
                _gameDAO.drawCard(ref player2);
                _gameDAO.decreaseNumberOfCardsLeft();

                if (player1.cardDrawn.name > player2.cardDrawn.name)
                {
                    player1.pointsFromRound = 2;
                    player1.points += 2;
                }

                if (player2.cardDrawn.name > player1.cardDrawn.name)
                {
                    player2.pointsFromRound = 2;
                    player2.points += 2;
                }

                if (player1.cardDrawn.name == player2.cardDrawn.name)
                {
                    player1.pointsFromRound = 1;
                    player2.pointsFromRound = 1;
                    player1.points += 1;
                    player2.points += 1;
                }

                screen = _renderer.createGameScreen(ref player1, ref player2, _gameDAO.getNumberOfCardsLeft());
                _renderer.drawScreen(screen);
                if (_gameDAO.getNumberOfCardsLeft() == 0)
                {
                    _gameOver = true;
                }

                player1.pointsFromRound = 0;
                player2.pointsFromRound = 0;
            }
            determineWinner(player1, player2);
        }

        private void determineWinner(Player player1, Player player2)
        {
            StringBuilder screen = new();
            //Bestem vinder. Hvis det er lige returneres null;
            if (player1.points > player2.points)
            {
                screen = _renderer.createWonGameScreen(player1);
            }

            if (player2.points > player1.points)
            {
                screen = _renderer.createWonGameScreen(player2);
            }

            if (player2.points == player1.points)
            {
                // Hvis de er lige bruges null som parameter.
                Player emptyPlayer = new()
                {
                    human = true, name = player1.name + " & " + player2.name, playerNumber = 3, points = player1.points
                };
                screen = _renderer.createWonGameScreen(emptyPlayer);
            }

            _renderer.drawScreen(screen);
        }
    }
}
