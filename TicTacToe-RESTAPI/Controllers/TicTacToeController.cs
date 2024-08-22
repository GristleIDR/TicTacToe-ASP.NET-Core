using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;
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
        public ActionResult<char[][]> GameBoard()
        {
            char[,] gameBoard = _game.ShowGameBoard();
            char[][] jaggedArray = ConvertToJaggedArray(gameBoard);
            return Ok(jaggedArray);
        }

        [HttpGet("Player/{playerNumber}/Username")]
        public ActionResult<string> PlayerUsername(int playerNumber)
        {
            if (playerNumber == 1)
            {
                return Ok(_game.Player_1_Username);
            }
            else if (playerNumber == 2)
            {
                return Ok(_game.Player_2_Username);
            }
            else
            {
                return BadRequest("Invalid player number. Only 1 or 2 are allowed.");
            }
        }


        [HttpPut("Player/{playerNumber}/Username")]
        public ActionResult<string> PlayerUsername(int playerNumber, [FromQuery] string username)
        {
            if (playerNumber == 1)
            {
                _game.Player_1_Username = username;
                return Ok(_game.Player_1_Username);
            } else if (playerNumber == 2)
            {
                _game.Player_2_Username = username;
                return Ok(_game.Player_2_Username);
            } else
            {
                return BadRequest("Invalid player number. Only 1 or 2 are allowed.");
            }
            
        }

        [HttpGet("Player/{playerNumber}/Symbol")]
        public ActionResult<char> PlayerSymbol(int playerNumber)
        {
            if (playerNumber == 1)
            {
                return Ok(_game.Player_1_Symbol);
            }
            else if (playerNumber == 2)
            {
                return Ok(_game.Player_2_Symbol);
            }
            else
            {
                return BadRequest("Invalid player number. Only 1 or 2 are allowed.");
            }
        }

        [HttpPut("Player/{playerNumber}/Symbol")]
        public ActionResult<char> PlayerSymbol(int playerNumber, [FromQuery] char symbol)
        {
            if (playerNumber == 1)
            {
               _game.Player_1_Symbol = symbol;
                return Ok(_game.Player_1_Symbol);
            }
            else if (playerNumber == 2)
            {
                _game.Player_2_Symbol = symbol;
                return Ok(_game.Player_2_Symbol);
            }
            else
            {
                return BadRequest("Invalid player number. Only 1 or 2 are allowed.");
            }
        }

        [HttpPut("MakeMove")]
        public ActionResult<string> MakeMove([FromQuery] int x, [FromQuery] int y)
        {
            return Ok(_game.MakeMove(x, y));
        }

        [HttpGet("GameStatus")]
        public ActionResult<string> GameStatus()
        {
           return Ok(_game.Game_Status.ToString());
        }

        [HttpPut("ResetGame")]
        public ActionResult<string> ResetGame()
        {
            return Ok(_game.ResetGame());
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
