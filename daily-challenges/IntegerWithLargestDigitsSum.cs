using System;
using System.Linq;

public class Program
{
    static int GetSum(int n)
    {
        var sum = 0;
        while(n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        return sum;
    }
    
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        var arr = new int[N];
        int max = 1, maxIndex = 0;
        arr[0] = 1;
        for(int i = 2; i <= N; i++)
        {
            arr[i - 1] = GetSum(i);
            if(arr[i - 1] >= max)
            {
                max = arr[i - 1];
                maxIndex = i - 1;
            }
        }
        Console.Write(maxIndex + 1);
    }
}

