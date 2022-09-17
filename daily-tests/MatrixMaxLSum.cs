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
        var maxSum = M[0, 0] + M[1, 0] + M[1, 1];
        for(int i = 0; i < R - 1; i++)
        {
            for(int j = 0; j < C - 1; j++)
            {
                var sum = M[i, j] + M[i + 1, j] + M[i + 1, j + 1];
                if(sum > maxSum)
                    maxSum = sum;
            }
        }
        Console.Write(maxSum);
    }
}