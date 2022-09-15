using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        var arr = new int[N];
        int largeIndex = -1;
        for(int i = 0; i < N; i++)
        {
            var count = Console.ReadLine().Trim().Split(' ').Select(char.Parse).Distinct().Count();
            if (largeIndex == -1)
            {
                largeIndex = 0;
            }
            else
            {
                if(count >= arr[largeIndex])
                {
                    largeIndex = i;
                }
            }
            arr[i] = count;
        }
        Console.WriteLine(largeIndex + 1);
    }
}