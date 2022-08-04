using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        var list = Console.ReadLine().Trim().Split(' ').Select(long.Parse).ToList();
        var max = list.Max();
        var fibo = new List<int>();
        int a = 0, b = 1, c = 1;
        fibo.Add(a);
        fibo.Add(b);
        while(c <= max)
        {
            fibo.Add(c);
            a = b;
            b = c;
            c = a + b;
        }
        foreach(var value in list)
            if(fibo.Contains(value))
                Console.Write(value + " ");
    }
}