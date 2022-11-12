using System;

public class program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("1");
        for(int i = 2; i <= N; i++)
        {
            Console.Write(i);
            for(int j = i - 2; j > 0; j--)
                Console.Write('*');
            Console.WriteLine(i);
        }
    }
}