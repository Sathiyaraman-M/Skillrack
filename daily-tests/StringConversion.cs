using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        var tokens = Console.ReadLine().Trim().Split(' ');
        var s1 = tokens[0].Trim();
        var s2 = tokens[1].Trim();
        int count = 0;
        foreach(var i in s1)
        {
            if(char.IsUpper(i))
            {
                if(!s2.Contains(i))
                {
                    Console.Write("NO");
                    return;
                }
                else
                    count++;
            }
            else
            {
                if(s2.Contains(char.ToUpper(i)))
                    count++;
            }
        }
        Console.Write("YES");
    }
}