using System;

public class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        var list = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        int S = int.Parse(Console.ReadLine());
        int leftIndex = 0, rightIndex = 0, sum = list[0];
        while(leftIndex < N && rightIndex < N)
        {
            if(sum == S)
            {
                Console.Write("Yes");
                return;
            }
            else if(sum < S)
            {
                rightIndex++;
                if(rightIndex < N)
                    sum += list[rightIndex];
            }
            else
            {
                leftIndex++;
                sum -= list[leftIndex - 1];
            }
        }
        Console.Write("No");
    }
}