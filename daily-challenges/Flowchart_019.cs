using System;
using System.Linq;

public class Program
{
    static char ReplaceVowels(char c)
    {
        if("aeiouAEIOU".Contains(c))
        {
            return c;
        }
        else
        {
            if(c == 'z')
            {
                return 'b';
            }
            else
            {
                if("aeiouAEIOU".Contains((char)((int)c + 1)))
                {
                    return (char)((int)c + 2);
                }
                else
                {
                    return (char)((int)c + 1);
                }
            }
        }
    }
    
    static void Main()
    {
        var input = Console.ReadLine().Trim();
        foreach(var i in input)
        {
            Console.Write(ReplaceVowels(i));
        }
    }
}