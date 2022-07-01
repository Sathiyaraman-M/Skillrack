using System;

public class Program
{
    public static void Main(string[] args)
    {
        var N = long.Parse(Console.ReadLine().Trim());
        Console.WriteLine(N * (N.ToString().Length));
    }
}
