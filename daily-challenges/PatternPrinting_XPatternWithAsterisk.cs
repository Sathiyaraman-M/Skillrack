using System;
using System.Linq;

public class Program
{
    static int N;
    
    static void PrintStar(int count)
    {
        for(int i = 0; i < count; i++)
            Console.Write("*");
    }
    
    static void PrintLine(int i)
    {
        PrintStar(i);
        Console.Write(i + 1);
        PrintStar(2 * N - 2 * i - 3);
        Console.Write(i + 1);
        PrintStar(i);
        Console.WriteLine();
    }
    
    static void Main()
    {
        N = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < N - 1; i++)
            PrintLine(i);
        
        PrintStar(N - 1);
        Console.Write(N);
        PrintStar(N - 1);
        Console.WriteLine();
        
        for(int i = N - 2; i >= 0; i--)
            PrintLine(i);
    }
}