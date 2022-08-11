using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        var tokens = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        int R = tokens[0], C = tokens[1];
        for(int i = 0; i < R; i++)
        {
            var lines = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            for(int j = 0; j < C; j++)
                Console.Write((lines[j] + lines.Last() % 10) + " ");
            Console.WriteLine();
        }
    }
}