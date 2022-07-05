using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        var tokens = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
        int R = tokens[0], C = tokens[1];
        int[,] M = new int[R, C], P = new int[R, C];
        for(int i = 0; i < R; i++)
        {
            var line = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
            for(int j = 0; j < C; j++)
            {
                M[i, j] = line[j];
                P[i, j] = 0;
            }
        }
        P[R - 1, 0] = M[R - 1, 0];
        for(int i = 1; i < C; i++)
        {
            if(M[R - 1, i] == 1) P[R - 1, i] = P[R - 1, i + 1];
        }
        for(int i = 1; i < R; i++)
        {
            if(M[i, 0] == 1) P[i, 0] = P[i - 1, 0];
        }
        for(int i = 1; i < R; i++)
        {
            for(int j = 1; j < C; j++)
            {
                if(M[i, j] == 1)
                    P[i, j] = P[i, j - 1] + P[i + 1, j];
            }
        }
        Console.Write(P[0, C - 1] > 0 ? $"yes {P[0, C - 1]}" : "no");
    }
}