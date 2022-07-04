using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        var list = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
        foreach(var i in list)
        {
            if(((i / 100) % 10) % 2 != 0)
            {
                Console.WriteLine(i);
                return;
            }
        }
    }
}
