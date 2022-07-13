using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        var tokens = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        int X = tokens[0], Y = tokens[1], counter = 0;
        while(X < Y)
        {
            if(Y % 2 != 0) Y += 1;
            else Y /= 2;
            counter++;
        }
        Console.Write(counter + (X - Y));
    }
}