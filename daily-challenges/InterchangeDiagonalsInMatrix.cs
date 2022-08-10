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
        for(int i = 0; i < N; i++)
        {
            for(int j = 0; j < N; j++)
            {
                if(j == i)
                    Console.Write(M[i, N - i - 1] + " ");
                else if(j == N - i - 1)
                    Console.Write(M[i, N - j - 1] + " ");
                else
                    Console.Write(M[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}