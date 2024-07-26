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

        [Fact]
        public void SetPlayer1SymbolTest()
        {
            // Create Test Objects
            var game1 = new Game();
            var game2 = new Game();
            var game3 = new Game();
            var game4 = new Game();

            // Set Player 1 Symbol to X
            game1.Player_1_Symbol = 'X';
            // Assert That Player 1 Symbol is X
            Assert.Equal('X', game1.Player_1_Symbol);

            // Set Player 1 Symbol to x
            game2.Player_1_Symbol = 'x';
            // Assert That Player 1 Symbol is X
            Assert.Equal('X', game2.Player_1_Symbol);

            // Set Player 1 Symbol to O
            game3.Player_1_Symbol = 'O';
            // Assert That Player 1 Symbol is O
            Assert.Equal('O', game3.Player_1_Symbol);

            // Set Player 1 Symbol to o
            game4.Player_1_Symbol = 'o';
            // Assert That Player 1 Symbol is O
            Assert.Equal('O', game4.Player_1_Symbol);

            // Test Attempting To Change Player 1 Symbol After It Has Been Set
            // Expected Result: Player 1 Symbol Should Not Change

            // Set Player 1 Symbol to X
            game1.Player_1_Symbol = 'O';
            // Assert That Player 1 Symbol is X
            Assert.Equal('X', game1.Player_1_Symbol);

            // Set Player 1 Symbol to x
            game2.Player_1_Symbol = 'o';
            // Assert That Player 1 Symbol is X
            Assert.Equal('X', game2.Player_1_Symbol);

            // Set Player 1 Symbol to O
            game3.Player_1_Symbol = 'X';
            // Assert That Player 1 Symbol is O
            Assert.Equal('O', game3.Player_1_Symbol);

            // Set Player 1 Symbol to o
            game4.Player_1_Symbol = 'x';
            // Assert That Player 1 Symbol is O
            Assert.Equal('O', game4.Player_1_Symbol);
        }

        [Fact]
        public void SetPlayer2SymbolTest()
        {
            // Create Test Objects
            var game1 = new Game();
            var game2 = new Game();
            var game3 = new Game();
            var game4 = new Game();

            // Set Player 2 Symbol to X
            game1.Player_2_Symbol = 'X';
            // Assert That Player 2 Symbol is X
            Assert.Equal('X', game1.Player_2_Symbol);

            // Set Player 2 Symbol to x
            game2.Player_2_Symbol = 'x';
            // Assert That Player 2 Symbol is X
            Assert.Equal('X', game2.Player_2_Symbol);

            // Set Player 2 Symbol to O
            game3.Player_2_Symbol = 'O';
            // Assert That Player 2 Symbol is O
            Assert.Equal('O', game3.Player_2_Symbol);

            // Set Player 2 Symbol to o
            game4.Player_2_Symbol = 'o';
            // Assert That Player 2 Symbol is O
            Assert.Equal('O', game4.Player_2_Symbol);

            // Test Attempting To Change Player 2 Symbol After It Has Been Set
            // Expected Result: Player 2 Symbol Should Not Change

            // Set Player 2 Symbol to X
            game1.Player_2_Symbol = 'O';
            // Assert That Player 2 Symbol is X
            Assert.Equal('X', game1.Player_2_Symbol);

            // Set Player 2 Symbol to x
            game2.Player_2_Symbol = 'o';
            // Assert That Player 2 Symbol is X
            Assert.Equal('X', game2.Player_2_Symbol);

            // Set Player 2 Symbol to O
            game3.Player_2_Symbol = 'X';
            // Assert That Player 2 Symbol is O
            Assert.Equal('O', game3.Player_2_Symbol);

            // Set Player 2 Symbol to o
            game4.Player_2_Symbol = 'x';
            // Assert That Player 2 Symbol is O
            Assert.Equal('O', game4.Player_2_Symbol);
        }

        [Fact]
        public void MakeMoveTest()
        {
            // Create Test Objects
            var TestGameNotSetup = new Game();
            var TestInvalidMove = new Game();
            var TestValidMove = new Game();
            var TestWinningMovePlayer1 = new Game();
            var TestWinningMovePlayer2 = new Game();
            var TestDrawMove = new Game();

            // Test Making A Move Before The Players Are Setup
            // Expected Result: "Please Finish Setting Up The Players"
            Assert.Equal("Please Finish Setting Up The Players", TestGameNotSetup.MakeMove(0, 0));

            // Test Making Invalid Moves
            // Expected Result: "Player ? Invalid Move"
            TestInvalidMove.Player_1_Username = "Player 1";
            TestInvalidMove.Player_2_Username = "Player 2";
            TestInvalidMove.Player_1_Symbol = 'X';

            // Test Player 1 Invalid Move
            Assert.Equal("Player 1 Invalid Move", TestInvalidMove.MakeMove(3, 0));
            Assert.Equal("Player 1 Invalid Move", TestInvalidMove.MakeMove(0, 3));
            Assert.Equal("Player 1 Invalid Move", TestInvalidMove.MakeMove(3, 3));
            Assert.Equal("Player 1 Invalid Move", TestInvalidMove.MakeMove(-2, -4));

            TestInvalidMove.SwitchPlayer();

            // Test Player 2 Invalid Move
            Assert.Equal("Player 2 Invalid Move", TestInvalidMove.MakeMove(3, 0));
            Assert.Equal("Player 2 Invalid Move", TestInvalidMove.MakeMove(0, 3));
            Assert.Equal("Player 2 Invalid Move", TestInvalidMove.MakeMove(3, 3));
            Assert.Equal("Player 2 Invalid Move", TestInvalidMove.MakeMove(-2, -4));

            // Test Making Valid Moves
            // Expected Result: "Move Accepted"
            TestValidMove.Player_1_Username = "Player 1";
            TestValidMove.Player_2_Username = "Player 2";
            TestValidMove.Player_1_Symbol = 'X';

            // Test Player 1 Valid Move
            Assert.Equal("Move Accepted", TestValidMove.MakeMove(0, 0));

            // Test Player 2 Valid Move
            Assert.Equal("Move Accepted", TestValidMove.MakeMove(0, 1));

            // Test Making Winning Move Player 1
            // Expected Result: "Congratulations 1 You Have Won!"
            TestWinningMovePlayer1.Player_1_Username = "Player 1";
            TestWinningMovePlayer1.Player_2_Username = "Player 2";
            TestWinningMovePlayer1.Player_1_Symbol = 'X';

            Assert.Equal("Move Accepted", TestWinningMovePlayer1.MakeMove(0, 0));
            Assert.Equal("Move Accepted", TestWinningMovePlayer1.MakeMove(0, 1));
            Assert.Equal("Move Accepted", TestWinningMovePlayer1.MakeMove(1, 0));
            Assert.Equal("Move Accepted", TestWinningMovePlayer1.MakeMove(1, 1));
            Assert.Equal("Congratulations Player 1 You Have Won!", TestWinningMovePlayer1.MakeMove(2, 0));

            // Test Making Winning Move Player 2
            // Expected Result: "Congratulations 2 You Have Won!"
            TestWinningMovePlayer2.Player_1_Username = "Player 1";
            TestWinningMovePlayer2.Player_2_Username = "Player 2";
            TestWinningMovePlayer2.Player_1_Symbol = 'X';

            Assert.Equal("Move Accepted", TestWinningMovePlayer2.MakeMove(2, 2));
            Assert.Equal("Move Accepted", TestWinningMovePlayer2.MakeMove(0, 0));
            Assert.Equal("Move Accepted", TestWinningMovePlayer2.MakeMove(0, 1));
            Assert.Equal("Move Accepted", TestWinningMovePlayer2.MakeMove(1, 0));
            Assert.Equal("Move Accepted", TestWinningMovePlayer2.MakeMove(1, 1));
            Assert.Equal("Congratulations Player 2 You Have Won!", TestWinningMovePlayer2.MakeMove(2, 0));

            // Test Draw Move
            // Expected Result: "The Game Was a Draw"
            TestDrawMove.Player_1_Username = "Player 1";
            TestDrawMove.Player_2_Username = "Player 2";
            TestDrawMove.Player_1_Symbol = 'O';

            Assert.Equal("Move Accepted", TestDrawMove.MakeMove(0, 0));
            Assert.Equal("Move Accepted", TestDrawMove.MakeMove(0, 1));
            Assert.Equal("Move Accepted", TestDrawMove.MakeMove(0, 2));
            Assert.Equal("Move Accepted", TestDrawMove.MakeMove(2, 2));
            Assert.Equal("Move Accepted", TestDrawMove.MakeMove(1, 1));
            Assert.Equal("Move Accepted", TestDrawMove.MakeMove(1, 2));
            Assert.Equal("Move Accepted", TestDrawMove.MakeMove(2, 1));
            Assert.Equal("Move Accepted", TestDrawMove.MakeMove(2, 0));
            Assert.Equal("The Game Was a Draw", TestDrawMove.MakeMove(1, 0));
        }
    }
}