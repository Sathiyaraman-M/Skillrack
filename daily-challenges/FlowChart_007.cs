using System;
using System.Linq;

public class Program
{
    static void PrintSeries(int M, int N)
    {
        for(int i = M; i >= N; i--)
            Console.Write(i);
    }
    
    static void Main()
    {
        var tokens = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        int X = tokens[0], Y = tokens[1], Z = tokens[2];
        if(X > Y)
            PrintSeries(X, Y);
        else
            PrintSeries(Y, X);
        if(Y > Z)
            PrintSeries(Y, Z);
        else
            PrintSeries(Z, Y);
    }
}