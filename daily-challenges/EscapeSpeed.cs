using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        var list = Console.ReadLine().Trim().Split(' ').Select(double.Parse).ToList();
        Console.WriteLine(Math.Sqrt(2 * list[0] * list[1] /  list[2]).ToString("0.000"));
    }
}