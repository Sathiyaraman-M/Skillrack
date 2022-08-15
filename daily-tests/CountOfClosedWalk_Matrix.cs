using System;
using System.Linq;

public class Program
{
    static bool IsEven(int x) => x % 2 == 0;
    
    static void Main()
    {
        var tokens = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        int M = tokens[0], N = tokens[1];
        var matrix = new int[M, M];
        for(int i = 0; i < M; i++)
        {
            var line = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            for(int j = 0; j < M; j++)
                matrix[i, j] = line[j];
        }
        bool flag = false;
        int count = 0;
        for(int i = 0; i <= M - N; i++)
        {
            for(int j = 0; j <= M - N; j++)
            {
                flag = true;
                for(int row = 0; row < N; row++)
                {
                    if(row != 0 && row != N - 1)
                    {
                        if(!IsEven(matrix[i + row, j + 0]) || !IsEven(matrix[i + row, j + N - 1]))
                        {
                            flag = false;
                            break;
                        }
                    }
                    else
                    {
                        for(int col = 0; col < N; col++)
                        {
                            if(!IsEven(matrix[i + row, j + col]))
                            {
                                flag = false;
                                break;
                            }
                        }
                    }
                }
                if(flag)
                    count++;
            }
        }
        Console.Write(count);
    }
}