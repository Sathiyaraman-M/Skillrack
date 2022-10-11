using System;

public class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        var arr = new int[10];
        while(N > 0)
        {
            arr[N % 10]++;
            N /= 10;
        }
        for(int i = 0; i < 10; i++) Console.Write(arr[i]);
    }
}