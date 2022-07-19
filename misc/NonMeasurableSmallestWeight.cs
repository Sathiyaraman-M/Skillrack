using System;
using System.Linq;
 
public class Hello
{
    static void Main()
	{
		int N = int.Parse(Console.ReadLine());
		var list = Console.ReadLine().Trim().Split(' ').Select(int.Parse).OrderBy(x => x).ToList();
		int weight = 1;
		foreach(var i in list)
		{
		    if(weight < i)
		    {
		        Console.Write(weight);
		        return;
		    }
		    else
		        weight += i;
		}
		Console.Write(weight);
	}
}