using System;

public class Program
{
    static void Main(string[] args)
    {
        var str = Console.ReadLine().Trim();
        Console.Write(str[0]);
        Console.Write(str[str.Length - 1]);
    }
}
