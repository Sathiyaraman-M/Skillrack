using System;
using System.Collections.Generic;
using System.Linq;
 
public class Program
{
    static void Main()
    {
        var tokens = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        int R = tokens[0], C = tokens[1];
        
        var list = Console.ReadLine().Trim().Split(' ').Where(x => !string.IsNullOrEmpty(x)).Select(int.Parse).ToList();
        
        var values = new List<int>();
        for(int i = 0; i < list.Count; i++)
            for(int j = 0; j < list[i]; j++)
                values.Add(i + 1);
                
        for(int i = 0; i < R; i++)
        {
            var subset = values.Skip(i * C).Take(C).ToList();
            if(i % 2 != 0)
                subset.Reverse();
            foreach(var value in subset)
                Console.Write(value + " ");
            Console.WriteLine();
        }
    }
}