using System;

public class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine(0);
        for(int i = 0; i < N; i++)
        {
            for(int j = N - i; j < N; j++)
                Console.Write(j);
            Console.Write($"{N}0{N}");
            for(int j = N - 1; j >= N - i; j--)
                Console.Write(j);
            Console.WriteLine();
        }
    }
}