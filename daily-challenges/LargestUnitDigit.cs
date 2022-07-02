using System;

public class Program
{
    static void Main(string[] args)
    {
        var tokens = Console.ReadLine().Trim().Split(' ');
        var X = int.Parse(tokens[0]);
        var Y = int.Parse(tokens[1]);
        Console.WriteLine(X % 10 == Y % 10 ? (X > Y ? X : Y) : (X % 10 > Y % 10 ? X : Y));
    }
}
