using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        ulong N = ulong.Parse(Console.ReadLine());
        var count = new int[10];
        while(N > 0)
        {
            count[N % 10]++;
            N /= 10;
        }
        for(int i = 1; i <= 9; i++)
        {
            if (count[i] > i)
            {
                Console.WriteLine("No");
                return;
            }   
        }
        Console.WriteLine("Yes");
    }
}