using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        var list = Console.ReadLine().Trim().Split(' ').Select(x => int.Parse(x)).ToList();
        int currSum = list[0], maxSum = list[0];
        for(int i = 1; i < N; i++)
        {
            currSum = Math.Max(currSum + list[i], list[i]);
            if(currSum > maxSum) maxSum = currSum;
        }
        Console.WriteLine(maxSum);
    }
}