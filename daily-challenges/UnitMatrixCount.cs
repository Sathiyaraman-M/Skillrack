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
            var line = Console.ReadLine().Trim().Split(' ').Select(x => int.Parse(x)).ToList();
            for(int j = 0; j < N; j++)
                M[i, j] = line[j];
        }
        int count = 0;
        for(int i = 0; i < N - 1; i++)
        {
            for(int j = 0; j < N - 1; j++)
            {
                if(M[i, j] == 1 && M[i + 1, j] == 1 && M[i, j + 1] == 1 && M[i + 1, j + 1] == 1)
                    count++;
            }
        }
        Console.Write(count);
    }
}