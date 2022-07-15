using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        var list = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        int count = 0;
        for(int i = 1; i < (1 << N); i++)
        {
            int sum = 0;
            for(int j = 0; j < N; j++)
                if((i & (1 << j)) != 0)
                    sum += list[j];
            if (sum == 0)
                count++;
        }
        Console.Write(count);
    }
}