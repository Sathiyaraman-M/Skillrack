using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        var list = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).Where(x => ((x / 10) % 10) % 2 != 0);
        Console.WriteLine((list.Sum() / (float)list.Count()).ToString("0.00"));
    }
}
