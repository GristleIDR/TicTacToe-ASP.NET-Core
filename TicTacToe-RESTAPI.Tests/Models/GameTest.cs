using TicTacToe_RESTAPI.Models;

namespace TicTacToe_RESTAPI.Tests.Models
{
    public class GameTest
    {
        [Fact]
        public void ConsuctorTest()
        {
            // Create Test Object
            Game game = new Game();

            // Assert That Game Status is InProgress and The Current Player is 1
            Assert.Equal(Game.Status.InProgress, game.GetStatus());
            Assert.Equal(1, game.GetCurrentPlayer());
        }

        [Fact]
        public void SetStatusTest()
        {
            // Create Test Object
            Game game = new Game();

            // Set Status to Win
            game.SetStatus(Game.Status.Win);

            // Assert That Game Status is Win
            Assert.Equal(Game.Status.Win, game.GetStatus());

            // Set Status to Draw
            game.SetStatus(Game.Status.Draw);

            // Assert That Game Status is Draw
            Assert.Equal(Game.Status.Draw, game.GetStatus());

            // Set Status to InProgress
            game.SetStatus(Game.Status.InProgress);

            // Assert That Game Status is InProgress
            Assert.Equal(Game.Status.InProgress, game.GetStatus());
        }

        [Fact]
        public void SetCurrentPlayerTest()
        {
            // Create Test Object
            Game game = new Game();

            // Set Current Player to 2
            game.SetCurrentPlayer(2);

            // Assert That Current Player is 2
            Assert.Equal(2, game.GetCurrentPlayer());

            // Set Current Player to 1
            game.SetCurrentPlayer(1);

            // Assert That Current Player is 1
            Assert.Equal(1, game.GetCurrentPlayer());
        }

        [Fact]
        public void SwitchPlayerTest()
        {
            // Create a Test Object
            Game game = new Game();

            // Assert That Current Player is 1
            Assert.Equal(1, game.GetCurrentPlayer());

            game.SwitchPlayer();

            // Assert That The Current Player is 2
            Assert.Equal(2, game.GetCurrentPlayer());

            game.SwitchPlayer();

            // Assert That The Current Player is Back to 1
            Assert.Equal(1, game.GetCurrentPlayer());
        }
    }
}