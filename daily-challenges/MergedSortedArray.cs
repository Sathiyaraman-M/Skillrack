using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        Console.ReadLine();
        var list = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        list.AddRange(Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList());
        foreach(var val in list.OrderByDescending(x => x))
            Console.Write(val + " ");
    }
}