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
            Assert.Equal(Game.Status.InProgress, game.Game_Status);
            Assert.Equal(1, game.Current_Player);
        }

        [Fact]
        public void SetStatusTest()
        {
            // Create Test Object
            Game game = new Game();

            // Set Status to Win
            game.Game_Status = Game.Status.Win;

            // Assert That Game Status is Win
            Assert.Equal(Game.Status.Win, game.Game_Status);

            // Set Status to Draw
            game.Game_Status = Game.Status.Draw;

            // Assert That Game Status is Draw
            Assert.Equal(Game.Status.Draw, game.Game_Status);

            // Set Status to InProgress
            game.Game_Status = Game.Status.InProgress;

            // Assert That Game Status is InProgress
            Assert.Equal(Game.Status.InProgress, game.Game_Status);
        }

        [Fact]
        public void SetCurrentPlayerTest()
        {
            // Create Test Object
            Game game = new Game();

            // Set Current Player to 2
            game.Current_Player = 2;

            // Assert That Current Player is 2
            Assert.Equal(2, game.Current_Player);

            // Set Current Player to 1
            game.Current_Player = 1;

            // Assert That Current Player is 1
            Assert.Equal(1, game.Current_Player);
        }

        [Fact]
        public void SwitchPlayerTest()
        {
            // Create a Test Object
            Game game = new Game();

            // Assert That Current Player is 1
            Assert.Equal(1, game.Current_Player);

            game.SwitchPlayer();

            // Assert That The Current Player is 2
            Assert.Equal(2, game.Current_Player);

            game.SwitchPlayer();

            // Assert That The Current Player is Back to 1
            Assert.Equal(1, game.Current_Player);
        }

        [Fact]
        public void SetPlayer1UsernameTest()
        {
            // Create Test Object
            Game game = new Game();

            // Set Player 1 Username to "Test"
            game.Player_1_Username = "Test";

            // Assert That Player 1 Username is "Test"
            Assert.Equal("Test", game.Player_1_Username);

            // Set Player 1 Username to Empty
            game.Player_1_Username = "";

            // Assert That Player 1 Username is Empty
            Assert.Equal("Player 1", game.Player_1_Username);

            // Set Player 1 Username to Null
            game.Player_1_Username = "\0";

            // Assert That Player 1 Username is Empty
            Assert.Equal("Player 1", game.Player_1_Username);
        }

        [Fact]
        public void SetPlayer2UsernameTest() {
            // Create Test Object
            Game game = new Game();

            // Set Player 2 Username to "Test"
            game.Player_2_Username = "Test";

            // Assert That Player 2 Username is "Test"
            Assert.Equal("Test", game.Player_2_Username);

            // Set Player 2 Username to Empty
            game.Player_2_Username = "";

            // Assert That Player 2 Username is Empty
            Assert.Equal("Player 2", game.Player_2_Username);

            // Set Player 2 Username to Null
            game.Player_2_Username = "\0";

            // Assert That Player 2 Username is Empty
            Assert.Equal("Player 2", game.Player_2_Username);
        }
    }
}