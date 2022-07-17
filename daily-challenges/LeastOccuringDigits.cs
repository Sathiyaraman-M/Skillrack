using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        var list = Console.ReadLine().Trim().Split(' ').Select(long.Parse).ToList();
        var digits = new int[10];
        foreach(var i in list)
        {
            long val = i;
            while(val != 0)
            {
                digits[val % 10]++;
                val /= 10;
            }
        }
        var min = digits.Where(x => x > 0).Min();
        for(int i = 0; i < 10; i++)
            if(digits[i] == min)
                Console.Write(i + " ");
    }
}