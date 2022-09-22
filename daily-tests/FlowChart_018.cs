using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine(Enumerable.Range(1, N).Select(x => x * x * x).Sum());
    }
}