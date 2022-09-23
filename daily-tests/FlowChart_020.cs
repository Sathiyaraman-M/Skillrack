using System;

public class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        for(int i = 1; i <= N; i++)
        {
            int printVal = i % 2 == 0 ? 2 : 1;
            for(int j = 1; j <= i; j++)
            {
                Console.Write(printVal);
                printVal += 2;
            }
            Console.WriteLine();
        }
    }
}