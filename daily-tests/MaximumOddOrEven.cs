using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        var list = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        for(int i = 0; i < N; i++)
        {
            if(list[i] % 2 != 0)
            {
                var sublist = list.GetRange(0, i + 1).Where(x => x % 2 != 0).ToList();
                if(sublist.Count > 0)
                {
                    Console.Write(sublist.Max() + " ");
                }
                else
                {
                    Console.Write(list[i] + " ");
                }
            }
            else
            {
                var sublist = list.GetRange(i, N - i).Where(x => x % 2 == 0).ToList();
                if(sublist.Count > 0)
                {
                    Console.Write(sublist.Max() + " ");
                }
                else
                {
                    Console.Write(list[i] + " ");
                }
            }
        }
    }
}