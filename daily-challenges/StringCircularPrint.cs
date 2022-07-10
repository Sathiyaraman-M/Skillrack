using System;

public class Program
{
    static void Main(string[] args)
    {
        var str = Console.ReadLine().Trim();
        var N = int.Parse(Console.ReadLine());
        var len = str.Length;
        for(int i = 0; i < N; i++)
        {
            Console.Write(str[i % len]);
        }
    }
}