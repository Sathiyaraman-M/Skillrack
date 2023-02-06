using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Trim();
        var y = input.Count(x => x == 'y');
        var n = input.Count(x => x == 'n');
        Console.Write(y == n ? "EQUAL" : (y > n ? "YES" : "NO"));
    }
}