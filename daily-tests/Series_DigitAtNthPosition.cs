using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        var tokens = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        int M = tokens[0], N = tokens[1];
        var str = "";
        for(int i = 1; i <= M; i++)
        {
            str += i.ToString();
            if(str.Length >= N)
            {
                Console.WriteLine(str[N - 1]);
                return;
            }
        }
    }
}