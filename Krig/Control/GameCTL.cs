using System.Text;
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

        internal void run(Player player1, Player player2)
        {
            StringBuilder screen;

            // Vis start skærm.
            screen = _renderer.startScreen();
            _renderer.drawScreen(screen);


            // Et gameloop
            while (!_gameOver)
            {
                // træk kort for begge spillere.
                _gameDAO.drawCard(ref player1);
                _gameDAO.drawCard(ref player2);
                // nedskriv antal kort/runder tilbage
                _gameDAO.decreaseNumberOfCardsLeft();

                // hvis spiller1 kort > spiller 2 kort, giv point til spiller 1
                if (player1.cardDrawn.name > player2.cardDrawn.name)
                {
                    player1.pointsFromRound = 2;
                    player1.points += 2;
                }

                // hvis spiller2 kort > spiller1 kort, giv point til spiller 2
                if (player2.cardDrawn.name > player1.cardDrawn.name)
                {
                    player2.pointsFromRound = 2;
                    player2.points += 2;
                }

                // Hvis de er lige store, giv point til begge spillere
                if (player1.cardDrawn.name == player2.cardDrawn.name)
                {
                    player1.pointsFromRound = 1;
                    player2.pointsFromRound = 1;
                    player1.points += 1;
                    player2.points += 1;
                }

                // skab og vis resultatet på via GameScreen.
                screen = _renderer.createGameScreen(ref player1, ref player2, _gameDAO.getNumberOfCardsLeft());
                _renderer.drawScreen(screen);

                // Hvis der ikke er flere kort/runder tilbage efter den her kom ud af loopet 
                if (_gameDAO.getNumberOfCardsLeft() == 0)
                {
                    _gameOver = true;
                }
                
                // nulstil rundepointene, så der kan vises nye næste gang.
                player1.pointsFromRound = 0;
                player2.pointsFromRound = 0;
            }

            // Man er ude af loopet når der ikke er flere kort tilbage, og så skal der bestemmes en vinder
            determineWinner(player1, player2);
        }

        private void determineWinner(Player player1, Player player2)
        {
            StringBuilder screen = new();

            //Der bliver lavet en WonGameScreen for den relevante vinder.
            if (player1.points > player2.points)
            {
                screen = _renderer.createWonGameScreen(player1);
            }

            if (player2.points > player1.points)
            {
                screen = _renderer.createWonGameScreen(player2);
            }

            // Hvis det blev uafgjort bliver der skabt en midlertidig spiller som indeholder de data der skal til for at 
            // Renderer kan generere den rigtige vinder skærm.
            if (player2.points == player1.points)
            {
                // Hvis de er lige bruges null som parameter.
                Player emptyPlayer = new()
                {
                    human = true, name = player1.name + " & " + player2.name, playerNumber = 3, points = player1.points
                };
                screen = _renderer.createWonGameScreen(emptyPlayer);
            }

            // vis vinderskærmen.
            _renderer.drawScreen(screen);
        }
    }
}
