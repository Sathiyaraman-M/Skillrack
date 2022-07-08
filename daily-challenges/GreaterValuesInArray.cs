using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        var tokens = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        int N = tokens[0], M = tokens[1];
        var list = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        for(int i = 0; i < N; i++)
        {
            if(list[i] > M) Console.Write(list[i] + " ");
        }
    }
}