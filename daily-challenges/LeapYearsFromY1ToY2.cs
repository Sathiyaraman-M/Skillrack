using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        var tokens = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        var list = Enumerable.Range(tokens[0], tokens[1] - tokens[0] + 1).Where(x => x % 4 == 0 && x % 100 != 0 || x % 400 == 0).ToList();
        if(list.Count == 0)
        {
            Console.Write("-1");
            return;
        }
        foreach(var i in list)
        {
            Console.Write(i + " ");
        }
    }
}