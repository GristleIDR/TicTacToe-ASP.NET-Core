using System.Reflection.Metadata.Ecma335;
using TicTacToe_RESTAPI.Models;

namespace TicTacToe_RESTAPI.Models
{
    public class Game
    {
        private Status game_status;
        private int current_player = 0;

        private Board game_board;
        private Player player_1;
        private Player player_2;
        public enum Status { Win, Draw, InProgress }

        public Game()
        {
            this.game_status = Status.InProgress;
            this.current_player = 1;
            this.game_board = new Board();
            this.player_1 = new Player();
            this.player_2 = new Player();
        }

        public Status Game_Status
        {
            get => this.game_status;
            set => this.game_status = value;
        }

        public int Current_Player
        {
            get => this.current_player;
            set => this.current_player = value;
        }

        public string Player_1_Username
        {
            get => this.player_1.Username;
            set
            {
                if (value == "" || value == "\0")
                {
                    this.player_1.Username = "Player 1";
                }
                else
                {
                    this.player_1.Username = value;
                }
            }
        }

        public char Player_1_Symbol
        {
            get => this.player_1.Symbol;
            set
            {
                if (this.player_1.Symbol == '\0' && this.player_2.Symbol == '\0' && (value == 'X' || value == 'x' || value == 'O' || value == 'o'))
                {
                    if (value == 'X' || value == 'x')
                    {
                        this.player_1.Symbol = 'X';
                        this.player_2.Symbol = 'O';
                    }
                    else
                    {
                        this.player_1.Symbol = 'O';
                        this.player_2.Symbol = 'X';
                    }
                }
            }
        }

        public string Player_2_Username
        {
            get => this.player_2.Username;
            set
            {
                if (value == "" || value == "\0")
                {
                    this.player_2.Username = "Player 2";
                }
                else
                {
                    this.player_2.Username = value;
                }
            }
        }

        public char Player_2_Symbol
        {
            get => this.player_2.Symbol;
            set
            {
                if (this.player_2.Symbol == '\0' && this.player_1.Symbol == '\0' && (value == 'X' || value == 'x' || value == 'O' || value == 'o'))
                {
                    if (value == 'X' || value == 'x')
                    {
                        this.player_2.Symbol = 'X';
                        this.player_1.Symbol = 'O';
                    }
                    else
                    {
                        this.player_2.Symbol = 'O';
                        this.player_1.Symbol = 'X';
                    }
                }
            }
        }

        public string MakeMove(int x, int y)
        {
            // Check To Make Sure The Players Are Set
            if (this.Player_1_Symbol == '\0' || this.Player_2_Symbol == '\0' || this.Player_1_Username == "" || this.Player_2_Username == "")
            {
                return "Please Finish Setting Up The Players";
            }

            // If the move is out of bounds or a player has already claimed the square, return an error message
            if (x < 0 || x > 2 || y < 0 || y > 2 || this.game_board.GetPosition(x, y) != '\0')
            {
                return "Player " + this.Current_Player + " Invalid Move";
            }
            else
            {
                if (this.current_player == 1)
                {
                    this.game_board.MakeMove(this.player_1.Symbol, x, y);
                }
                else
                {
                    this.game_board.MakeMove(this.player_2.Symbol, x, y);
                }

                this.SwitchPlayer();
                this.UpdateCurrentGameStatus();

                // Check for Game Conclusion
                if (this.Game_Status == Status.Win || this.Game_Status == Status.Draw)
                {
                    if (this.game_status == Status.Win)
                    {
                        if (this.current_player == 1)
                        {
                            return "Congratulations " + this.player_2.Username + " You Have Won!";
                        }
                        else
                        {
                            return "Congratulations " + this.player_1.Username + " You Have Won!";
                        }
                    }
                    else
                    {
                        return "The Game Was a Draw";
                    }
                }
                return "Move Accepted";
            }
        }

        public char[,] ShowGameBoard()
        {
            return this.game_board.BoardState;
        }

        public void UpdateCurrentGameStatus()
        {
            if (this.game_board.IsDraw())
            {
                this.game_status = Status.Draw;
            }
            else if (this.game_board.IsWinner(player_1.Symbol) || this.game_board.IsWinner(this.player_2.Symbol))
            {
                this.game_status = Status.Win;
            }
            else
            {
                this.game_status = Status.InProgress;
            }
        }
        public void SwitchPlayer()
        {
            if (this.current_player == 1)
            {
                this.current_player = 2;
            }
            else
            {
                this.current_player = 1;
            }
        }
    }
}