using System;
using System.Linq;

public class Program 
{
    static void Main() 
    {
        var inputs = Console.ReadLine().Split('#').ToList();
        foreach(var i in inputs.Skip(1).Take(inputs.Count - 2)) 
        {
            Console.Write(i);
        }
    }
}