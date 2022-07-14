using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        var list = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        for(int i = 0; i < N - 1; i++)
            if(list[i] % 10 == list[i + 1] % 10)
                Console.Write(list[i] + " ");
    }
}