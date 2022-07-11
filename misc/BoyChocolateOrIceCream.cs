using System;

public class Program
{
    static long Chocolate { get; set; } = 1;
    static long IceCream { get; set; } = 1;
    static long Count => Chocolate + IceCream;
    static long temp = Chocolate;

    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        if(N == 1)
        {
            Console.Write(Count);
            return;
        }
        for(int i = 2; i <= N; i++)
        {
            temp = Chocolate;
            Chocolate += IceCream;
            IceCream = temp;
        }
        Console.Write(Count);
    }
}