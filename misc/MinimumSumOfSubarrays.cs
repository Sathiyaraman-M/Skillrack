using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        var list = Console.ReadLine().Trim().Split(' ').Select(x => int.Parse(x)).ToList();
        int minSum = list[0];
        int currSum = list[0] < 0 ? list[0] : 0;
        for(int i = 1; i < N; i++)
        {
            currSum += list[i];
            if(currSum < minSum) minSum = currSum;
            if(currSum > 0) currSum = 0;
        }
        Console.Write(minSum);
    }
}