using System;

public class Program
{
    static void Main(string[] args)
    {
        int count = 0;
        var str = Console.ReadLine().Trim();
        foreach(var i in str)
        {
            if(char.IsUpper(i)) count++;
        }
        Console.Write(count);
    }
}