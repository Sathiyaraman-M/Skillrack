using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        var tokens = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        int R = tokens[0], C = tokens[1];
        for(int i = 0; i < R; i++)
        {
            for(int j = 1; j <= C; j++)
                Console.Write((i + j) + " ");
            Console.WriteLine();
        }
    }
}