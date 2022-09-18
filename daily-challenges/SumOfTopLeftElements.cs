using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        var tokens = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        int R = tokens[0], C = tokens[1];
        var M = new int[R, C];
        for(int i = 0; i < R; i++)
        {
            var line = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            for(int j = 0; j < C; j++)
                M[i, j] = line[j];
        }
        var sum = 0;
        int row = R % 2 == 0 ? R / 2 : (R / 2) + 1;
        int col = C % 2 == 0 ? C / 2 : (C / 2) + 1;
        for(int i = 0; i < row; i++)
            for(int j = 0; j < col; j++)
                sum += M[i, j];
        Console.Write(sum);
    }
}