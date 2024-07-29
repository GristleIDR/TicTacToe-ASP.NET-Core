namespace TicTacToe_RESTAPI.Models
{
    public class Player
    {
        private string username;
        private char symbol;
        private int wins;
        private int losses;
        public Player(string username, char symbol)
        {
            this.username = username;
            this.symbol = symbol;
            this.wins = 0;
            this.losses = 0;
        }

        public Player()
        {
            this.username = "";
            this.symbol = '\0';
            this.wins = 0;
            this.losses = 0;
        }

        public string Username
        {
            get => this.username;
            set => this.username = value;
        }
        
        public char Symbol
        {
            get => this.symbol;
            set => this.symbol = value;
        }

        public int Wins
        {
            get => this.wins;
        }

        public void IncrementWins()
        {
            this.wins++;
        }

        public int Losses
        {
            get => this.losses;
        }

        public void IncrementLosses()
        {
            this.losses++;
        }

        public string ResetPlayer()
        {
            this.username = "";
            this.symbol = '\0';
            this.wins = 0;
            this.losses = 0;

            return "Player Reset";
        }
    }
}
