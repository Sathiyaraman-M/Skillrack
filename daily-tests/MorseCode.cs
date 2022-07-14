using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var output = "";
        while(!string.IsNullOrEmpty(input))
        {
            int count = input.Trim().Split(' ').Count();
            output += (char)((int)'a' + count - 1);
            input = Console.ReadLine();
        }
        Console.Write(output);
    }    
}