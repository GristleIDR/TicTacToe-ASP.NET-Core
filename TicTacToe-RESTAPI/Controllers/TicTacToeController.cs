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

        [HttpGet("ShowGameBoard")]
        public IActionResult ShowGameBoard()
        {
            char[,] gameBoard = _game.ShowGameBoard();
            char[][] jaggedArray = ConvertToJaggedArray(gameBoard);
            return Ok(jaggedArray);
        }

        [HttpPut("SetPlayerOneUsername")]
        public IActionResult SetPlayerOneUserName([FromQuery] string username)
        {
            _game.Player_1_Username = username;
            return Ok(_game.Player_1_Username);
        }

        [HttpPut("SetPlayerTwoUsername")]
        public IActionResult SetPlayerTwoUserName([FromQuery] string username)
        {
            _game.Player_2_Username = username;
            return Ok(_game.Player_2_Username);
        }

        [HttpPut("SetPlayerOneSymbol")]
        public IActionResult SetPlayerOneSymbol([FromQuery] char symbol)
        {
            _game.Player_1_Symbol = symbol;
            return Ok(_game.Player_1_Symbol);
        }

        [HttpPut("MakeMove")]
        public IActionResult MakeMove([FromQuery] int x, [FromQuery] int y)
        {
            return Ok(_game.MakeMove(x, y));
        }

        [HttpGet("CheckGameStatus")]
        public IActionResult CheckGameStatus()
        {
           return Ok(_game.Game_Status);
        }

        [HttpPut("ResetGame")]
        public string ResetGame()
        {
            return "Game Reset";
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
