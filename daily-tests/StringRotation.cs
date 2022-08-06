using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        var s1 = Console.ReadLine().Trim();
        var s2 = Console.ReadLine().Trim();
        for(int i = 0; i < s1.Length; i++)
        {
            var modified = s1.Substring(i) + s1.Substring(0, i);
            if (modified == s2) 
            {
                Console.WriteLine("YES");
                return;
            }
        }
        Console.WriteLine("NO");
    }
}