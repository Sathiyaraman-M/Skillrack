using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        var tokens = Console.ReadLine().Trim().Split(' ').Select(x => int.Parse(x)).ToList();
        int M = tokens[0], N = tokens[1];
        while(M != N)
            Console.Write(M < N ? M++ : N++);
        Console.Write(M);
    }
}