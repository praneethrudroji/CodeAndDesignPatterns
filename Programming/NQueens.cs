using System;
using System.Text;
using System.Collections.Generic;

namespace Programming;

public class NQueensClass
{
    private static void GenerateBoard(int n,
                                        List<List<string>> result,
                                        List<string> current_board,
                                        int current_row) 
    {
        if(current_row == n) {
            result.Add([.. current_board]);
            return;
        }

        for(int current_column = 0; current_column < n; current_column++) 
        {
            if(isSafe(current_board, current_row, current_column)) {
                var sb = new StringBuilder(new string('.', n));
                sb[current_column] = 'Q';
                current_board.Add(sb.ToString());
                GenerateBoard(n, result, current_board, current_row + 1);
                current_board.RemoveAt(current_board.Count - 1);
            }
        }
    }

    private static bool isSafe(List<string> current_board, 
                                     int current_row, int current_column) 
    {
        //If current board is empty, then it is safe to place Queen at any position
        if(current_board.Count == 0) return true;

        return false;
    }

    
    public static List<List<string>> NQueens(int n)
    {
        if(n == 0) return [];
        List<List<string>> result = [];
        GenerateBoard(n, result, [], 0);
        return result;
    }
}
