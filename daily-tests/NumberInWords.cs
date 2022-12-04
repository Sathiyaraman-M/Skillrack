using System;

enum Number : int
{
    zero,
    one,
    two,
    three,
    four,
    five,
    six,
    seven,
    eight,
    nine
}

public class Program
{
    static void Main()
    {
        var N = Console.ReadLine().Trim();
        foreach(var ch in N)
            Console.Write(((Number)int.Parse(ch.ToString())).ToString() + " ");
    }
}