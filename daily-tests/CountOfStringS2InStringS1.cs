using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        var tokens = Console.ReadLine().Trim().Split(' ');
        string s1 = tokens[0].Trim(), s2 = tokens[1].Trim();
        int count = 0;
        for(int i = 0; i <= s1.Length - s2.Length; i++)
        {
            if(s1[i] == s2[0])
            {
                int j = 0;
                while(j < s2.Length && s1[i + j] == s2[j]) j++;
                if(j == s2.Length) count++;
            }
        }
        Console.Write(count);
    }
}