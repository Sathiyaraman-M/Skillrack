using System;

public class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        for(int i = 1; i <= N; i += 2)
            Console.Write(i);
    }
}