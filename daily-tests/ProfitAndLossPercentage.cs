using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        var list = new string[N];
        for(int i = 0; i < N; i++)
            list[i] = Console.ReadLine().Trim();
        int M = int.Parse(Console.ReadLine());
        int profitCount = 0, lossCount = 0;
        for(int i = 0; i < N; i++)
        {
            var input = list[i].Split(' ').Select(int.Parse).ToList();
            int CP = input[0], SP = input[1];
            if(CP > SP)
            {
                if(((CP - SP) * 100 / CP) >= M)
                    lossCount++;
            }
            else
            {
                if(((SP - CP) * 100 / CP) >= M)
                    profitCount++;
            }
        }
        Console.WriteLine($"{profitCount} {lossCount}");
    }
}