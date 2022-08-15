using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        var tokens = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        int A = tokens[0], X = tokens[1], Y = tokens[2];
        int count = 0;
        while(A >= X + Y)
        {
            A -= X + Y;
            count++;
        }
        Console.Write(count);
    }
}