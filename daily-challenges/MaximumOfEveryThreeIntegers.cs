using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        var list = Console.ReadLine().Trim().Split(' ').Select(x => int.Parse(x)).ToList();
        for(int i = 0; i < N / 3; i++)
        {
            Console.Write(list.Skip(i * 3).Take(3).Max() + " ");
        }
    }
}