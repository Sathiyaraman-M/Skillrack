using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        var prefix = Console.ReadLine().Trim();
        for(int i = 0; i < N - 1; i++)
        {
            var input = Console.ReadLine().Trim();
            for(int j = 0; j < prefix.Length; j++)
            {
                if(prefix[j] != input[j])
                {
                    prefix = input.Substring(0, j);
                    if(string.IsNullOrEmpty(prefix))
                    {
                        Console.WriteLine("-1");
                        return;
                    }
                    break;
                }
            }
        }
        Console.WriteLine(prefix);
    }
}