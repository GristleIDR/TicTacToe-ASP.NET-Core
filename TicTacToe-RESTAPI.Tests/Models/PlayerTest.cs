using TicTacToe_RESTAPI.Models;

namespace TicTacToe_RESTAPI.Tests.Models
{
    public class PlayerTest
    {
        [Fact]
        public void ConstructorTest()
        {
            // Create Test Object
            Player testPlayer1 = new Player("Bob", 'X');
            Player testPlayer2 = new Player();

            // Assertions
            Assert.True(testPlayer1.Username == "Bob");
            Assert.True(testPlayer1.Symbol == 'X');
            Assert.True(testPlayer2.Username == "");
            Assert.True(testPlayer2.Symbol == '\0');
        }

        [Fact]
        public void SetUsernameTest()
        {
            // Create Test Object
            Player testPlayer = new Player();

            // Set The Username
            testPlayer.Username = "test";

            // Assertions
            Assert.Equal("test", testPlayer.Username);
            Assert.Equal('\0', testPlayer.Symbol);
        }

        [Fact]
        public void SetSymbolTest()
        {
            // Create Test Object
            Player testPlayer = new Player();

            // Set The Symbol
            testPlayer.Symbol = 'O';

            // Assertions
            Assert.Equal("", testPlayer.Username);
            Assert.Equal('O', testPlayer.Symbol);
        }

        [Fact]
        public void IncrementWinsTest()
        {
            // Create Test Object
            Player player = new Player();

            // Assert Default Values
            Assert.Equal("", player.Username);
            Assert.Equal('\0', player.Symbol);
            Assert.Equal(0, player.Wins);
            Assert.Equal(0, player.Losses);

            // Increment Wins
            player.IncrementWins();

            // Verify That Wins Incremented and Didn't Change Other Values
            Assert.Equal("", player.Username);
            Assert.Equal('\0', player.Symbol);
            Assert.Equal(1, player.Wins);
            Assert.Equal(0, player.Losses);
        }

        [Fact]
        public void IncrementLossesTest()
        {
            // Create Test Object
            Player player = new Player();

            // Assert Default Values
            Assert.Equal("", player.Username);
            Assert.Equal('\0', player.Symbol);
            Assert.Equal(0, player.Wins);
            Assert.Equal(0, player.Losses);

            // Increment Losses
            player.IncrementLosses();

            // Verify That Wins Incremented and Didn't Change Other Values
            Assert.Equal("", player.Username);
            Assert.Equal('\0', player.Symbol);
            Assert.Equal(0, player.Wins);
            Assert.Equal(1, player.Losses);
        }
    }
}
