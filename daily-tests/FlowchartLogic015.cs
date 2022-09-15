using System;

public class Program
{
    static void Main()
    {
        double M;
        int N;
        var tokens = Console.ReadLine().Trim().Split(' ');
        M = double.Parse(tokens[0]);
        N = int.Parse(tokens[1]);
        while(N > 0)
        {
            M /= 10;
            N--;
        }
        Console.WriteLine(M.ToString("0.0000"));
    }
}