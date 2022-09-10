using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        int M = int.Parse(Console.ReadLine());
        int temp = M, N = 0;
        while(temp > 0)
        {
            N = N * 10 + temp % 10;
            temp /= 10;
        }
        while(M > 0)
        {
            Console.Write($"{N % 10}{M % 10}");
            N /= 10;
            M /= 10;
        }
    }
}