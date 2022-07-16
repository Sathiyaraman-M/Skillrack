using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        var tokens = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        int M = tokens[0], N = tokens[1];
        while(N > 0)
        {
            if(M % 10 == 0) M /= 10;
            else M--;
            N--;
        }
        Console.Write(M);
    }
}