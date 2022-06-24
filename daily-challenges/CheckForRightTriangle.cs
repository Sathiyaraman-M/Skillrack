using System;
using System.Linq;

class Program
{
    static void Main(string args[])
    {
        var input = Console.ReadLine().Split().Select(x => int.Parse(x)).Select(x => x * x).ToList();
        var max = input.Max();
        Console.WriteLine(max == input.Where(x => x != max).Sum() ? "yes" : "no");
    }
}
