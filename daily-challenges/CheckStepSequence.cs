using System;
using System.Linq;

public class Program
{
    public static void Main(string args[])
    {
        int N = int.Parse(Console.ReadLine());
        var list = Console.ReadLine().Trim().Split(' ').Select(x => int.Parse(x)).ToList();
        for(int i = 0; i < list.Count() - 1; i++)
        {
            if(Math.Abs(list[i] - list[i + 1]) != 1)
            {
                Console.WriteLine("no");
                return;
            }
        }
        Console.WriteLine("yes");
    }
}
