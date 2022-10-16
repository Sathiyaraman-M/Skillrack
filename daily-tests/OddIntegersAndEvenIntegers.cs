using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        var list = Console.ReadLine().Trim().Split(' ').Select(x => int.Parse(x)).ToList();
        foreach(var i in list.Where(x => x % 2 != 0))
            Console.Write(i + " ");
        foreach(var i in list.Where(x => x % 2 == 0))
            Console.Write(i + " ");
    }
}