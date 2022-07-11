using System;
using System.Linq;

public class Program
{
    static bool IsPrime(int N)
    {
        for(int i = 2; i < N; i++)
            if(N % i == 0)
                return false;
        return true;
    }
    
    static void Main(string[] args)
    {
        var tokens = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        int start = tokens[0], end = tokens[1];
        var values = Enumerable.Range(start, end - start + 1).Where(IsPrime).ToList();
        int product = 1;
        foreach(var i in values)
            product *= i;
        Console.Write(product);
    }
}