using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Trim();
        int K = int.Parse(Console.ReadLine());
        int N = input.Length, i = 0;
        bool printNow = true;
        while(i < N)
        {
            if(printNow)
            {
                if(i + K >= N)
                    Console.Write(input.Substring(i));
                else
                    Console.Write(input.Substring(i, K));
            }
            i += K;
            printNow = !printNow;
        }
    }
}