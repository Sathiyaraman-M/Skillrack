using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        var tokens = Console.ReadLine().Trim().Split(' ').Select(x => int.Parse(x)).ToList();
        int R = tokens[0], C = tokens[1];
        var M = new int[R, C];
        for(int i = 0; i < R; i++)
        {
            var line = Console.ReadLine().Trim().Split(' ').Select(x => int.Parse(x)).ToList();
            for(int j = 0; j < C; j++)
                M[i, j] = line[j];
        }
        int sum = 0;
        for(int i = 1; i < R - 1; i++)
            for(int j = 1; j < C - 1; j++)
                sum += M[i, j];
        Console.Write(sum);
    }
}