using System;
using System.Linq;

public class Program 
{
    static void Main()
    {
        var tokens = Console.ReadLine().Trim().Split(' ').Select(x => long.Parse(x)).ToList();
        long X = tokens[0], Y = tokens[1];
        long rem1 = X % 10, rem2 = Y % 10;
        Console.WriteLine($"{X - rem1 + rem2} {Y - rem2 + rem1}");
    }
}