using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        var list = Console.ReadLine().Trim().Split(' ').Select(int.Parse).Distinct().ToList();
        foreach(var i in list)
            Console.Write(i + " ");
    }
}