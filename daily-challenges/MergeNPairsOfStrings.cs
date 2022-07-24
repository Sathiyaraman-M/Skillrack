using System;
using System.Linq;
 
public class Program
{
    static void PrintMergedStrings(string input)
    {
        var words = input.Split(' ');
        int len1 = words[0].Length;
        int len2 = words[1].Length;
        int i = 0, j = 0, k = 0;
        while(i < len1 && j < len2)
        {
            Console.Write(k % 2 == 0 ? words[0][i++] : words[1][j++]);
            k++;
        }
        Console.WriteLine(i != len1 ? words[0].Substring(i) : words[1].Substring(j));
    }
    
    static void Main()
	{
	    int N = int.Parse(Console.ReadLine());
	    for(int i = 0; i < N; i++)
	        PrintMergedStrings(Console.ReadLine().Trim());
	}
}