using System;
using System.Collections.Generic;

public class Program 
{
    static void Main() 
    {
        var input = Console.ReadLine().Trim().Split(' ');
        var X = int.Parse(input[0]);
        var Y = int.Parse(input[1]);
        var list = new List<int>();
        while(X > 0 && Y > 0) 
        {
            list.Add((X % 10) * (Y % 10));
            X /= 10;
            Y /= 10;
        }
        var len = list.Count;
        for(int i = len - 1; i >= 0; i--) 
        {
            Console.Write($"{list[i]} ");
        }
    }
}