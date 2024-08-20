using Microsoft.AspNetCore.Mvc;
using TicTacToe_RESTAPI.Models;

namespace TicTacToe_RESTAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TicTacToeController : ControllerBase
    {
        private readonly Game _game;

        // Inject the Game object into the controller
        public TicTacToeController(Game game)
        {
            _game = game;
        }

        [HttpGet("GameBoard")]
        public char[][] GameBoard()
        {
            char[,] gameBoard = _game.ShowGameBoard();
            char[][] jaggedArray = ConvertToJaggedArray(gameBoard);
            return jaggedArray;
        }

        [HttpPut("Player/Username/{playerNumber}")]
        public string SetPlayerOneUserName(int playerNumber, [FromQuery] string username)
        {
            if (playerNumber == 1)
            {
                _game.Player_1_Username = username;
                return _game.Player_1_Username;
            } else if (playerNumber == 2)
            {
                _game.Player_2_Username = username;
                return _game.Player_2_Username;
            } else
            {
                return "Invalid player number. Only 1 or 2 are allowed.";
            }
            
        }

        [HttpPut("Player/Symbol/{playerNumber}")]
        public char SetPlayerOneSymbol(int playerNumber, [FromQuery] char symbol)
        {
            if (playerNumber == 1)
            {
               _game.Player_1_Symbol = symbol;
                return _game.Player_1_Symbol;
            }
            else if (playerNumber == 2)
            {
                _game.Player_2_Symbol = symbol;
                return _game.Player_2_Symbol;
            }
            else
            {
                return 'Z';
            }
        }

        [HttpPut("MakeMove")]
        public string MakeMove([FromQuery] int x, [FromQuery] int y)
        {
            return _game.MakeMove(x, y);
        }

        [HttpGet("GameStatus")]
        public string GameStatus()
        {
           return _game.Game_Status.ToString();
        }

        [HttpPut("ResetGame")]
        public string ResetGame()
        {
            return _game.ResetGame();
        }

        private char[][] ConvertToJaggedArray(char[,] multiArray)
        {
            int rows = multiArray.GetLength(0);
            int cols = multiArray.GetLength(1);
            char[][] jaggedArray = new char[rows][];

            for (int i = 0; i < rows; i++)
            {
                jaggedArray[i] = new char[cols];
                for (int j = 0; j < cols; j++)
                {
                    jaggedArray[i][j] = multiArray[i, j];
                }
            }

            return jaggedArray;
        }
    }
}
