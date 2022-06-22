using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        string output, temp;
        output = temp = string.Empty;
        int current = 0;
        bool reverse = false;
        for(int i = 0; i < N; i++)
        {
            for(int j = N - 1; j > i; j--) output += "-";
            temp = $"{++current}";
            for(int k = 0; k < i; k++)
            {
                if(reverse) temp = $"{++current}-" + temp;
                else temp += $"-{++current}";
            }
            reverse = !reverse;
            output += temp;
            Console.WriteLine(output);
            output = temp = string.Empty;
        }
    }
}
