using System;
using System.Linq;

public class Program 
{
    static void Main() 
    {
        var N = int.Parse(Console.ReadLine());
        var list = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        var X = int.Parse(Console.ReadLine());
        foreach(var i in list) 
        {
            Console.Write((i < X ? i + X : Math.Abs(i - X)) + " ");
        }
    }
}