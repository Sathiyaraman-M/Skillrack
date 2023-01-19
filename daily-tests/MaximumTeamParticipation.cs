using System;
using System.Linq;

public class Program 
{
    static void Main() 
    {
        var N = int.Parse(Console.ReadLine());
        Console.Write($"{(int)(Console.ReadLine().Trim().Split(' ').Select(int.Parse).Count(x => x >= 50) / 3)}");
    }
}