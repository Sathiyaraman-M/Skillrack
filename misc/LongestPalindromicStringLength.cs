using System;
using System.Linq;

public class Program{
    static void Main(string[] args)
    {
        var str = Console.ReadLine().Trim();
        int N = str.Length;
        int maxLen = 1;
        bool[,] M = new bool[N, N];
        for(int i = 0; i < N; i++)
        {
            M[i, i] = true;
        }
        for(int i = 0; i < N - 1; i++)
        {
            if(str[i] == str[i + 1])
            {
                M[i, i + 1] = true;
                maxLen = 2;
            }
        }
        for(int i = 3; i <= N; i++)
        {
            for(int j = 0; j <= N - i; j++)
            {
                if(str[j] == str[j + i - 1] && M[j + 1, i + j - 2])
                {
                    M[j, i + j - 1] = true;
                    if(i > maxLen) maxLen = i;
                }
            }
        }
        Console.Write(maxLen);
    }
}