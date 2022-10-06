using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine()), val = 1, i;
        for(i = 0; val <= N; i++, val *= 10) ;
        Console.Write(i);
    }
}