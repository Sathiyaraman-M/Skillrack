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
    
    static void PrintLine(int start, Func<int, bool> condition, Func<int, int> action)
    {
        for(int i = start; condition(i); i = action(i))
        {
            PrintStar(i);
            Console.Write(i + 1);
            PrintStar(2 * N - 2 * i - 3);
            Console.Write(i + 1);
            PrintStar(i);
            Console.WriteLine();
        }
    }
    
    static void Main()
    {
        N = int.Parse(Console.ReadLine());
        
        PrintLine(0, x => x < N - 1, x => x + 1);
        
        PrintStar(N - 1);
        Console.Write(N);
        PrintStar(N - 1);
        Console.WriteLine();
        
        PrintLine(N - 2, x => x >= 0, x => x - 1);
    }
}