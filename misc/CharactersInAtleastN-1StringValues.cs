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
            var local = new int[128];
            foreach(var ch in input)
            {
                if(local[(int)ch] == 0 && (counter[(int)ch] == i || counter[(int)ch] == i - 1))
                {
                    counter[(int)ch]++;
                    local[(int)ch]--;
                }
            }
        }
        for(int i = 1; i < 128; i++)
            if(counter[i] == N && counter[i] == N - 1)
                Console.Write((char)i);
    }
}