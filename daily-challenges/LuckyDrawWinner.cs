using System;
using System.Linq;

public class Hello
{
	public static void Main (string[] args)
	{
		int N = int.Parse(Console.ReadLine());
		var list = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
		var draws = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
		foreach(var i in draws)
		    list.Remove(list[i - 1]);
		Console.Write(list[0]);
	}
}