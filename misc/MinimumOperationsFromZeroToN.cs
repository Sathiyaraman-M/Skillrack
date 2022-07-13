using System;

public class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        if(N == 1 || N == 2)
        {
            Console.Write(N);
            return;
        }
        int counter = 0;
        while(N != 2)
        {
            if(N % 2 ! = 0) N -= 1;
            else N /= 2;
            counter++;
        }
        Console.Write(counter + 2);
    }
}