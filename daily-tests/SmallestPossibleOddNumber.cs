using System;
using System.Linq;
 
public class Hello
{
    static void Main()
    {
	    var tokens = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();
	    int N1 = tokens[0], N2 = tokens[1];
	    var digits = new int[10];
	    while(N1 != 0)
	    {
	        digits[N1 % 10]++;
	        N1 /= 10;
	    }
	    while(N2 != 0)
	    {
	        digits[N2 % 10]++;
	        N2 /= 10;
	    }
	    int unit = -1;
	    for(int i = 9; i > 0; i -= 2)
	    {
	        if(digits[i] > 0)
	        {
	            unit = i;
	            digits[i]--;
	            break;
	        }
	    }
	    if(unit == -1)
	    {
	        Console.Write(unit);
	        return;
	    }
	    int start = 0;
	    for(int i = 1; i <= 9; i++)
	    {
	        if(digits[i] > 0)
	        {
	            digits[i]--;
	            start = i;
	            Console.Write(start);
	            break;
	        }
	    }
	    for(int i = 0; i <= 9; i++)
	    {
	        while(digits[i]-- > 0)
	        {
	            Console.Write(i);
	        }
	    }
	    Console.Write(unit);
    }
}