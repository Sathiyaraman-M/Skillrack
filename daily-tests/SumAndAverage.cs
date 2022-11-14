using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        var list = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        Console.Write(list.Sum() + " " + list.Average().ToString("0.000"));
    }
}