using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        var tokens = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        int N = tokens[0], L = tokens[1];
        var list = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        var ways = new long[N + 1];
        ways[0] = 1;
        for(int i = 1; i <= N; i++)
        {
            for(int j = 0; j < L; j++)
            {
                if(i >= list[j])
                    ways[i] += ways[i - list[j]];
            }
        }
        Console.Write(ways[N]);
    }
}