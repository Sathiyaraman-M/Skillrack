using System;
using System.Linq;
 
public class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int count = 0;
        var arr = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        for(int i = 0; i < N - 1; i++)
            for(int j = i + 1; j < N; j++)
                if(arr[i] % arr[j] == 0 || arr[j] % arr[i] == 0)
                    count++;
        Console.Write(count);
    }
}