using System;

public class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int P = 1, res = 0;
        while(N > 0)
        {
            res += (N % 10) * P;
            P *= 2;
            N /= 10;
        }
        Console.WriteLine(res);
    }
}