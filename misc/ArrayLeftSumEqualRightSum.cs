using System;
using System.Linq;
 
public class Hello
{
	static void Main()
	{
		int N = int.Parse(Console.ReadLine());
		var list = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
		int leftSum = 0, rightSum = 0;
		for(int i = 1; i < N; i++)
		    rightSum += list[i];
	    if(leftSum == rightSum)
	        Console.Write(list[0] + " ");
	    for(int i = 1; i < N; i++)
	    {
	        leftSum += list[i - 1];
	        rightSum -= list[i];
	        if(leftSum == rightSum)
	            Console.Write(list[i] + " ");
	    }
	}
}