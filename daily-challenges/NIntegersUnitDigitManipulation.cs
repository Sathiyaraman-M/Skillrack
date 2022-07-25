using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        var list = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        Console.Write(list[0] * (list[N - 1] % 10) + " ");
        for(int i = 1; i < N; i++)
            Console.Write(list[i] * (list[i - 1] % 10) + " ");
    }
}