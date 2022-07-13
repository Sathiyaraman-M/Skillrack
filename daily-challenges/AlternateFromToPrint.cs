using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        var list = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        for(int i = 0; i < N - 1; i++)
        {
            var indices = list.Skip(i).Take(2).ToList();
            var values = Enumerable.Range(indices[0], indices[1] - indices[0] + 1).ToList();
            if(i % 2 != 0)
                values.Reverse();
            foreach(var val in values)
                Console.Write(val + " ");
        }
    }
}