using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        var tokens = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        int R = tokens[0], C = tokens[1];
        var M = new int[R, C + 1];
        for(int i = 0; i < R; i++)
        {
            var line = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            for(int j = 1; j <= C; j++)
                M[i, j] = line[j - 1] + M[i, j - 1];
        }
        int K = int.Parse(Console.ReadLine());
        int max = 0;
        for(int i = 0; i <= R - K; i++)
        {
            for(int j = 1; j <= C - K + 1; j++)
            {
                int sum = 0;
                for(int k = i; k < i + K; k++)
                    sum += M[k, j + K - 1] - M[k, j - 1];
                if(sum > max)
                    max = sum;
            }
        }
        Console.Write(max);
    }
}