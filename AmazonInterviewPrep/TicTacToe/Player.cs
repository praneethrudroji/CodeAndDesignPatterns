using System;

namespace AmazonInterviewPrep.TicTacToe;

public class Player
{
    public required string Name {get; set;}
    public required char Symbol {get; set;}
    public int Moves {get; set;}
    public bool IsWinner { get; set; }
}
