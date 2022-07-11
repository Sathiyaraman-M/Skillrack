using System;
using System.Linq;

public class Program
{
    static bool IsOdd(char N) => int.Parse(N.ToString()) % 2 != 0;
    
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Trim();
        var len = input.Length;
        if (IsOdd(input[1])) 
            Console.Write(input[0]);
        for(int i = 1; i < len - 1; i++)
            if(IsOdd(input[i - 1]) && IsOdd(input[i + 1])) 
                Console.Write(input[i]);
        if (IsOdd(input[len - 2])) 
            Console.Write(input[len - 1]);
    }
}