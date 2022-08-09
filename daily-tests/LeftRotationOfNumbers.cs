using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        var integers = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        var rotations = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        int N = integers.Count;
        foreach(var jump in rotations)
        {
            for(int i = 0; i < N; i++)
                Console.Write(integers[(jump + i) % N] + " ");
            Console.WriteLine();
        }
    }
}