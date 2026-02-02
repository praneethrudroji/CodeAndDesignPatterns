using System;

namespace AmazonInterviewPrep.TicTacToe
{


    /*
        Design a TicTacToe:
            - Initialize board with configurable size 'N'
            - Players should able to pick their symbol 'O' or 'X'
            - Player should able to enter position to place a symbol
            - Determine winner or draw
            - Handle invalid moves (out of bounds, position already taken)
            - Option to reset the game



        Entities: 

            - Board: 
                Configurable with size N x N
                Should track moves made by both the players, maximum moves will be N x N
                Draw the match if both the players are done with maximum moves
                Reset the board
                Display the board

            - Player:
                (+) Name: Player name
                (+) PlayerSymbol: 'O'/'X'
                (+) Moves Made till now
    */


    public class Board
    {
        private readonly int boardSize;
        private char[,] board;
        public int totalMoves;
        public Board(int boardSize)
        {
            if (boardSize < 3) throw new Exception("Board size should be greater than 3");
            this.boardSize = boardSize;
            board = new char[boardSize, boardSize];
            totalMoves = 0;
        }

        public void Display()
        {
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    Console.Write("|{0} ", string.Format("{0,2}", board[i, j] == '\0' ? string.Empty : board[i, j]));
                    if (j == boardSize - 1) Console.Write("|");
                }
                Console.WriteLine();

                if (i < boardSize - 1)
                {
                    Console.WriteLine("----+----+----");
                }
            }
            Console.WriteLine();
        }


        public void Reset()
        {
            board = new char[boardSize, boardSize];
            Console.Write("Resetted board");
        }

        public void MakeMove(Player player, int row, int column)
        {
            if (row >= boardSize || column >= boardSize) throw new Exception($"Invalid position [{row}, {column}]");
            if (board[row, column] != '\0') throw new Exception($"Position [{row}, {column}] is already occupied ");
            board[row, column] = player.Symbol;
            player.Moves += 1;
            totalMoves += 1;
            Console.WriteLine($"{player.Name} placed at [{row}, {column}]: ");
            Display();
            if (IsWinner(player, (row, column)))
            {
                player.IsWinner = true;
                Console.WriteLine($"{player.Name} won the game!");
                return;
            }
            if (totalMoves == boardSize * boardSize)
            {
                Console.WriteLine("Draw Match!!");
                return;
            }
        }

        public bool IsWinner(Player player, (int row, int column) position)
        {
            //Player should make minimum N moves to win
            if (player.Moves < boardSize) return false;
            int count = 0;
            //Check row
            for (int i = 0; i < boardSize; i++)
            {
                if (board[i, position.column] == player.Symbol)
                    count++;
            }
            if (count == boardSize) return true;

            //Check column
            count = 0;
            for (int i = 0; i < boardSize; i++)
            {
                if (board[position.row, i] == player.Symbol)
                    count++;
            }
            if (count == boardSize) return true;

            //Check top left to bottom right diagonal 

            count = 0;
            for (int i = 0; i < boardSize; i++)
            {
                if (board[i, i] == player.Symbol)
                    count++;
            }
            if (count == boardSize) return true;

            //Check bottom left to top right diagonal 
            count = 0;
            for (int i = 0; i < boardSize; i++)
            {
                if (board[boardSize - i - 1, i] == player.Symbol)
                    count++;
            }
            if (count == boardSize) return true;

            return false;
        }
    }
}