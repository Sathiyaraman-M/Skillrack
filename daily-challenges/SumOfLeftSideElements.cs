using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        var list = Console.ReadLine().Trim().Split(' ').Select(x => int.Parse(x)).ToList();
        for(int i = 0; i < N; i++)
            Console.Write(list.Take(i).Sum() + " ");
    }
}