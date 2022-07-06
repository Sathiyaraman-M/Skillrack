using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        var X = Console.ReadLine().Trim();
        var list = Console.ReadLine().Trim().Split(' ').ToList();
        foreach(var i in list)
        {
            Console.Write(i.Count(x => X == x.ToString()) + " ");
        }
    }
}