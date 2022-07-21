using System;
using System.Linq;
 
public class Hello
{
    static void Main()
    {
    	var tokens = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
    	int N = tokens[0], I = tokens[1], M = tokens[2];
    	int count = 0, curr = I;
    	if(M == N)
    	{
    	    Console.Write(1);
    	    return;
    	}
    	do
    	{
    	    curr = (curr + M) % N;
    	    count++;
    	}
    	while (curr != I);
    	Console.Write(count);
    }
}