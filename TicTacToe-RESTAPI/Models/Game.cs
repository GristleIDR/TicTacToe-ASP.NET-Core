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
                if (value != "")
                {
                    this.player_1.Username = value;
                } else
                {
                    this.player_1.Username = "Player 1";
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
                if (value != "")
                {
                    this.player_2.Username = value;
                } else
                {
                    this.player_2.Username = "Player 2";
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

        public void PlayGame()
        {
            // Print The Title Screen
            this.PrintTitleScreen();

            // Get Player 1 Username
            Console.WriteLine("Player 1: Please Select a Username: ");
            string player_1_username = Console.ReadLine();

            Console.WriteLine("\n" + player_1_username + ", Please Choose Your Symbol (X or O): ");
            string player_1_symbol = Console.ReadLine().ToUpper();

            // Get Player 2 Username
            Console.WriteLine("\nPlayer 2: Please Select a Username: ");
            string player_2_username = Console.ReadLine();

            // Set Player 1 symbol
            if (player_1_symbol == "X")
            {
                this.player_1.Symbol = 'X';
            }
            else if (player_1_symbol == "O")
            {
                this.player_1.Symbol = 'O';
            }
            else
            {
                this.player_1.Symbol = 'X';
            }

            // Give Player 2 The Opposite Symbol
            if (this.player_1.Symbol == 'X')
            {
                this.player_2.Symbol = 'O';
            }
            else
            {
                this.player_2.Symbol = 'X';
            }

            // Set Player Selections in Their Objects
            if (player_1_username == "")
            {
                this.player_1.Username = "Player 1";
            }
            else
            {
                this.player_1.Username = player_1_username;
            }

            if (player_2_username == "")
            {
                this.player_2.Username = "Player 2";
            }
            else
            {
                this.player_2.Username = player_2_username;
            }

            // Review Selections
            Console.WriteLine("\nPlayer 1: " + this.player_1.Username + " - Symbol: " + this.player_1.Symbol);
            Console.WriteLine("Player 2: " + this.player_2.Username + " - Symbol: " + this.player_2.Symbol);

            // Play Game Till a Winner or Draw
            while (this.game_status == Status.InProgress)
            {
                if (this.current_player == 1)
                {
                    Console.WriteLine("\n" + this.player_1.Username + " it is your turn...\n");
                }
                else
                {
                    Console.WriteLine("\n" + this.player_2.Username + " it is your turn...\n");
                }

                this.game_board.PrintBoard();

                Console.WriteLine("Select X Coordinate: \n");
                string x_axis = Console.ReadLine();

                Console.WriteLine("\nSelect Y Coordinate: \n");
                string y_axis = Console.ReadLine();

                int x = int.Parse(x_axis);
                int y = int.Parse(y_axis);

                if (this.current_player == 1)
                {
                    this.game_board.MakeMove(this.player_1.Symbol, x, y);
                }
                else
                {
                    this.game_board.MakeMove(player_2.Symbol, x, y);
                }

                this.SwitchPlayer();
                this.UpdateCurrentGameStatus();
            }
            this.PrintEndGame();
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
        public void PrintTitleScreen()
        {
            Console.WriteLine("--------------------------[ TicTacToe ]--------------------------\nProgrammer: Isaac Replogle\nGithub Project: https://github.com/GristleIDR/TicTacToe-CSharp\n\nWelcome...\n\n");
        }
        public void PrintEndGame()
        {
            Console.WriteLine("\n--------------------------[ TicTacToe ]--------------------------");

            if (this.game_status == Status.Win)
            {
                if (this.current_player == 1)
                {
                    Console.WriteLine("Congratulations " + this.player_2.Username + " You Have Won!\n");
                }
                else
                {
                    Console.WriteLine("Congratulations " + this.player_1.Username + " You Have Won!\n");
                }
            }
            else if (this.game_status == Status.Draw)
            {
                Console.WriteLine("The Game is a Draw!\n");
            }
            this.game_board.PrintBoard();
        }
    }
}