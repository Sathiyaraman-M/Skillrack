using System;
using System.Linq;

public class Program
{
    static void PrintList(int[] arr)
    {
        foreach(var i in arr)
            Console.Write(i + " ");
        Console.WriteLine();
    }
    
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        var M = new int[N, N];
        for(int i = 0; i < N; i++)
        {
            var line = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            for(int j = 0; j < N; j++)
                M[i, j] = line[j];
        }
        var l1 = new int[N];
        for(int i = 0; i < N; i++)
            for(int j = i; j < N; j++)
                l1[i] += M[j, j];
        var l2 = new int[N];
        for(int i = 0; i < N; i++)
            for(int j = i; j < N; j++)
                l2[i] += M[j, N - j - 1];
        if(l1.Sum() > l2.Sum())
        {
            PrintList(l1);
            PrintList(l2);
        }
        else
        {
            PrintList(l2);
            PrintList(l1);
        }
    }
}