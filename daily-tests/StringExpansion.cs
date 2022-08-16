using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Trim();
        for(int i = 1; i <= input.Length; i++)
            Console.Write(input.Substring(0, i));
    }
}