using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        var M = new int[N, N];
        for(int i = 0; i < N; i++)
        {
            var lines = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            for(int j = 0; j < N; j++)
                M[i, j] = lines[j];
        }
        for(int i = N / 2; i < N; i++)
        {
            for(int j = N / 2; j < N; j++)
                Console.Write(M[i, j] + " ");
            Console.WriteLine();
        }
    }
}