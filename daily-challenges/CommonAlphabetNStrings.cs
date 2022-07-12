using System;

public class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        var counter = new int[128];
        for(int i = 0; i < N; i++)
        {
            var input = Console.ReadLine().Trim();
            foreach(var ch in input)
                if(counter[(int)ch] == i)
                    counter[(int)ch]++;
        }
        int count = 0
        for(int i = 1; i < 128; i++)
            if(counter[i] == N)
                count++;
        Console.Write(count);
    }
}