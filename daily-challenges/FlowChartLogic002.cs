using System;

public class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        do
            Console.Write(N--);
        while(N > 0);
    }
}