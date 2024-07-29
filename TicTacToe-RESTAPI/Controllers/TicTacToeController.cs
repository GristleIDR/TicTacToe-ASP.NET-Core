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

        [HttpPut("CheckGameStatus")]
        public string CheckGameStatus()
        {
           return "Game Status";
        }

        [HttpPut("ResetGame")]
        public string ResetGame()
        {
            return "Game Reset";
        }
    }
}
