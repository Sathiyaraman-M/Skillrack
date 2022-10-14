using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        var tokens = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        int M = tokens[0], N = tokens[1];
        var list1 = Console.ReadLine().Trim().Split(' ').Where(x => !string.IsNullOrEmpty(x)).Select(int.Parse).ToArray();
        var list2 = Console.ReadLine().Trim().Split(' ').Where(x => !string.IsNullOrEmpty(x)).Select(int.Parse).ToArray();
        if(list2.Length == 0 || list2 == null)
        {
            Console.Write("Invalid");
            return;
        }
        var common = new List<int>();
        foreach(var value in list1)
            if(list2.Count(x => x == value) > 0 && !common.Contains(value))
                common.Add(value);
        if(common.Count() == 0)
        {
            Console.Write("Invalid");
            return;
        }
        foreach(var value in common)
            Console.Write(value + " ");
    }
}