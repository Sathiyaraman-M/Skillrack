using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Trim();
        var N = input.Length;
        for(int i = 0; i < N; i++)
        {
            for(int j = 0; j < N; j++)
            {
                if (i == j || i + j == N - 1)
                    Console.Write(input[N - i - 1]);
                else if (j == N / 2)
                    Console.Write(input[i]);
                else if (i == N / 2)
                    Console.Write(input[j]);
                else
                    Console.Write('*');
            }
            Console.WriteLine();
        }
    }
}