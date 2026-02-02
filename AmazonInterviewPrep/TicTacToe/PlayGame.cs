using System;

namespace AmazonInterviewPrep.TicTacToe;

public class PlayGame
{
    Player firstPlayer = new()
    {
        Name = "Praneeth",
        Symbol = 'O'
    };
    Player secondPlayer = new()
    {
        Name = "Pranaya",
        Symbol = 'X'
    };

    public PlayGame()
    {

    }

    public void StartGame()
    {
        LinkedList<Player> players = new();
        players.AddFirst(secondPlayer);
        players.AddFirst(firstPlayer);
        Random random = new();
        int boardSize = 3;
        Board board = new(boardSize);
        while (board.totalMoves != boardSize * boardSize)
        {
            try
            {
                int row = random.Next(0, boardSize);
                int column = random.Next(0, boardSize);
                var player = players.First();
                board.MakeMove(player, row, column);
                if(player.IsWinner) break;
                //Swap turns
                players.AddLast(player);
                players.RemoveFirst();
            }
            catch (System.Exception)
            {

            }
        }
    }
}
