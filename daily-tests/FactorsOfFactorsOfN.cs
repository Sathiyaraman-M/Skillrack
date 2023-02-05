using System;
using System.Collections.Generic;

public class Program
{
    static IEnumerable<int> GetFactors(int N)
    {
        for(int i = 1; i <= N; i++)
            if(N % i == 0)
                yield return i;
    }
    
    static void Main()
    {
        var N = int.Parse(Console.ReadLine().Trim());
        foreach(var factor in GetFactors(N))
        {
            foreach(var subFactor in GetFactors(factor))
                Console.Write($"{subFactor} ");
            Console.WriteLine();
        }
    }
}