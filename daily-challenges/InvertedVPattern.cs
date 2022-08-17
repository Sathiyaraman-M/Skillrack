using System;

public class Program
{
    static void PrintPattern(string s1, string s2)
    {
        var len = s1.Length;
        for(int i = 0; i < len; i++)
        {
            for(int j = 0; j < len - i - 1; j++) Console.Write("-");
            Console.Write(s1[len - i - 1]);
            for(int j = 0; j < i * 2 - 1; j++) Console.Write("-");
            if(i != 0) Console.Write(s2[i]);
            Console.WriteLine();
        }
    }
    
    static void Main()
    {
        var input1 = Console.ReadLine().Trim();
        var input2 = Console.ReadLine().Trim();
        if(input2[input2.Length - 1] == input1[0])
        {
            PrintPattern(input2, input1);
        }
        else if(input1[input1.Length - 1] == input2[0])
        {
            PrintPattern(input1, input2);
        }
        else
        {
            Console.WriteLine("-1");
            return;
        }
    }
}