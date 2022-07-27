using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static int N;
    static char[,] M;
    
    static IEnumerable<char> TopToBottomTraversal()
    {
        var result = new List<char>();
        for(int i = 0; i < N; i++)
            if(i % 2 == 0)
                for(int j = 0; j < N; j++)
                    result.Add(M[i, j]);
            else
                for(int j = N - 1; j >= 0; j--)
                    result.Add(M[i, j]);
        return result;
    }
    
    static IEnumerable<char> BottomToTopTraversal()
    {
        var result = new List<char>();
        bool reverse = true;
        for(int i = N - 1; i >= 0; i--)
        {
            if(!reverse)
                for(int j = 0; j < N; j++)
                    result.Add(M[i, j]);
            else
                for(int j = N - 1; j >=0; j--)
                    result.Add(M[i, j]);
            reverse = !reverse;
        }
        return result;
    }
    
    static void Main()
    {
        N = int.Parse(Console.ReadLine());
        M = new char[N, N];
        for(int i = 0; i < N; i++)
        {
            var lines = Console.ReadLine().Trim().Split(' ').Select(char.Parse).ToList();
            for(int j = 0; j < N; j++)
                M[i, j] = lines[j];
        }
        var ToB = TopToBottomTraversal().ToList();
        var BoT = BottomToTopTraversal().ToList();
        var result = string.Empty;
        for(int i = 0; i < ToB.Count / 2; i++)
            if(ToB[i] == BoT[i])
                result += ToB[i] + " ";
        if(N % 2 != 0)
            result += ToB[ToB.Count / 2];
        Console.WriteLine(string.IsNullOrEmpty(result) ? "-1" : result);
    }
}