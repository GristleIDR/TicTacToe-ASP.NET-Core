namespace TicTacToe_RESTAPI.Models
{
    public class Board
    {
        private char[,] board = { { '\0', '\0', '\0' }, { '\0', '\0', '\0' }, { '\0', '\0', '\0' }, };

        public char[,] BoardState
        {
            get => this.board;
            set => this.board = value;
        }

        public void MakeMove(char p, int x, int y)
        {
            this.board[x, y] = p;
        }
        public char GetPosition(int x, int y) => board[x, y];

        public void PrintBoard()
        {
            // Helper method to format the cell content
            string FormatCell(char cell)
            {
                return cell == '\0' ? " " : cell.ToString();
            }

            // Display the board with formatting adjustments
            Console.WriteLine("  Y\n" +
                              "2 |  " + FormatCell(this.board[0, 2]) + " | " + FormatCell(this.board[1, 2]) + " | " + FormatCell(this.board[2, 2]) +
                              "\n  | -----------\n" +
                              "1 |  " + FormatCell(this.board[0, 1]) + " | " + FormatCell(this.board[1, 1]) + " | " + FormatCell(this.board[2, 1]) +
                              "\n  | -----------\n" +
                              "0 |  " + FormatCell(this.board[0, 0]) + " | " + FormatCell(this.board[1, 0]) + " | " + FormatCell(this.board[2, 0]) +
                              "\n  -------------- X\n" +
                              "     0   1   2");
        }

        public void ClearBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = '\0';
                }

            }
        }

        public bool IsBoardFull()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == '\0')
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool IsWinner(char p)
        {
            // Check For Horizontal Wins
            if ((this.GetPosition(0, 0) == p && this.GetPosition(1, 0) == p && this.GetPosition(2, 0) == p) ||
                     (this.GetPosition(0, 1) == p && this.GetPosition(1, 1) == p && this.GetPosition(2, 1) == p) ||
                     (this.GetPosition(0, 2) == p && this.GetPosition(1, 2) == p && this.GetPosition(2, 2) == p))
            {
                return true;
            }
            // Check For Vertical Wins
            else if ((this.GetPosition(0, 0) == p && this.GetPosition(0, 1) == p && this.GetPosition(0, 2) == p) ||
                (this.GetPosition(1, 0) == p && this.GetPosition(1, 1) == p && this.GetPosition(1, 2) == p) ||
                (this.GetPosition(2, 0) == p && this.GetPosition(2, 1) == p && this.GetPosition(2, 2) == p))
            {
                return true;
            }
            // Check For Diagonal Wins
            else if ((this.GetPosition(0, 0) == p && this.GetPosition(1, 1) == p && this.GetPosition(2, 2) == p) ||
                     (this.GetPosition(0, 2) == p && this.GetPosition(1, 1) == p && this.GetPosition(2, 0) == p))
            {
                return true;
            }
            return false;
        }

        public bool IsDraw()
        {
            if (IsBoardFull() && !IsWinner('X') && !IsWinner('O'))
            {
                return true;
            }
            return false;
        }
    }
}
