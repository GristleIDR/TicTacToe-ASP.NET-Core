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
        public string ShowGameBoard()
        {
            
            return "Game Board";
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
