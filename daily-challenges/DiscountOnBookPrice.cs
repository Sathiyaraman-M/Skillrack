using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        var tokens = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        int X = tokens[0], Y = tokens[1];
        if(X >= 2 && X <= 4)
            Console.Write($"{((int)(X * Y * 0.9))}");
        else if(X == 5)
            Console.Write($"{((int)(X * Y * 0.8))}");
        else if(X > 5)
            Console.Write($"{((int)(X * Y * 0.5))}");
        else
            Console.Write($"{X * Y}");
    }
}