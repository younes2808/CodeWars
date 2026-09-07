using System;
​
public class TicTacToe
{
  public int IsSolved(int[,] board)
  {
    int[][] lines = new int[][]
    {
        // Rows
        new[] { board[0,0], board[0,1], board[0,2] },
        new[] { board[1,0], board[1,1], board[1,2] },
        new[] { board[2,0], board[2,1], board[2,2] },
        // Columns
        new[] { board[0,0], board[1,0], board[2,0] },
        new[] { board[0,1], board[1,1], board[2,1] },
        new[] { board[0,2], board[1,2], board[2,2] },
        // Diagonals
        new[] { board[0,0], board[1,1], board[2,2] },
        new[] { board[0,2], board[1,1], board[2,0] },
    };
​
    // Check for a winner first
    foreach (var line in lines)
    {
        if (line[0] != 0 && line[0] == line[1] && line[1] == line[2])
            return line[0]; // 1 = X wins, 2 = O wins
    }
​
    // Check for empty spots
    for (int i = 0; i < 3; i++)
        for (int j = 0; j < 3; j++)