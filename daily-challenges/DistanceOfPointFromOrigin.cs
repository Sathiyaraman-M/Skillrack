using System;

public class Program
{
    static void Main(string[] args)
    {
        var tokens = Console.ReadLine().Split(' ');
        int X = int.Parse(tokens[0]);
        int Y = int.Parse(tokens[1]);
        Console.Write(Math.Sqrt(X * X + Y * Y).ToString("0.00"));
    }
}