using System;

public class Program
{
    static int Index = 0;
    
    static int Square(int value) => value * value;
    
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        for(int i = 0; i < N; i++)
        {
            for(int j = N - i; j > 1; j--) Console.Write("* ");
            for(int j = 0; j < 2 * i + 1; j++) Console.Write(Square(++Index) + " ");
            for(int j = N - i; j > 1; j--) Console.Write("* ");
            Console.WriteLine();
        }
    }
}