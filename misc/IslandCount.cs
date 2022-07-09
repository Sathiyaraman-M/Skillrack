using System;
using System.Linq;

public class Program
{
    static int R, C;
    static int[,] M;
    static bool[,] visited;

    static void VisitAllAdjacentNodes(int x, int y)
    {
        visited[x, y] = true;
        for(int i = x - 1; i <= x + 1; i++)
        {
            for(int j = y - 1; j <= y + 1; j++)
            {
                if(i >= 0 && i < R && j >= 0 && j < C && M[i, j] == 1 && !visited[i, j])
                    VisitAllAdjacentNodes(i, j);
            }
        }
    }

    static void Main(string[] args)
    {
        var tokens = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        R = tokens[0];
        C = tokens[1];
        M = new int[R, C];
        for(int i = 0; i < R; i++)
        {
            var line = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            for(int j = 0; j < C; j++)
            {
                M[i, j] = line[j];
            }
        }
        int count = 0;
        visited = new bool[R, C];
        for(int i = 0; i < R; i++)
        {
            for(int j = 0; j < C; j++)
            {
                if(M[i, j] == 1 && !visited[i, j])
                {
                    VisitAllAdjacentNodes(i, j);
                    count++;
                }
            }
        }
        Console.Write(count);
    }
}