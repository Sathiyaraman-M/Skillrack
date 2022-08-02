using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        var tokens = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        int R = tokens[0], C = tokens[1];
        var matrix = new int[R * C];
        for(int i = 0; i < R; i++)
        {
            var lines = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            for(int j = 0; j < C; j++)
                matrix[i * C + j] = lines[j];
        }
        var uniqueValues = matrix.ToHashSet();
        foreach(var value in uniqueValues)
        {
            if(matrix.Count(x => x == value) > R)
            {
                Console.WriteLine("NO");
                return;
            }
        }
        Console.Write("YES");
    }
}