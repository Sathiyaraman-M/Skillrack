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
            var lines = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            for(int j = 0; j < C; j++)
                M[i, j] = lines[j];
        }
        int S = int.Parse(Console.ReadLine());
        for(int i = 0; i < R - 1; i++)
        {
            for(int j = 0; j < C - 1; j++)
            {
                int sum = 0;
                for(int row = i; row < i + 2; row++)
                    for(int col = j; col < j + 2; col++)
                        sum += M[row, col];
                if(sum == S)
                {
                    for(int row = i; row < i + 2; row++)
                    {
                        for(int col = j; col < j + 2; col++)
                        {
                            Console.Write(M[row, col] + " ");
                        }
                        Console.WriteLine();
                    }
                    return;
                }
            }
        }
    }
}