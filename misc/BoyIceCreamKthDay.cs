using System;
using System.Linq;

public class Program
{
    static long Chocolate { get; set; } = 1;
    static long IceCream { get; set; } = 1;
    static long Count => Chocolate + IceCream;
    static long temp = Chocolate;

    static void Main(string[] args)
    {
        var tokens = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        int N = tokens[0], K = tokens[1];
        if(N == 1)
        {
            Console.Write(Count);
            return;
        }
        for(int i = 2; i <= N; i++)
        {
            temp = Chocolate;
            Chocolate += IceCream;            
            if(i % K == 0)
            {
                IceCream += temp;
            }
            else
            {
                IceCream = temp;
            }
        }
        Console.Write(Count);
    }
}