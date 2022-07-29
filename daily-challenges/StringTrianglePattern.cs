using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        var inputs = Console.ReadLine().Trim().Split(' ').Where(x => !string.IsNullOrEmpty(x)).Select(x => x.Substring(x.Length - N)).ToList();
        for(int row = 1, i = 0; i < inputs.Count; row++)
        {
            for(int j = 0; j < row; j++)
            {
                if(i < inputs.Count)
                    Console.Write(inputs[i++]);
                else
                    for(int k = 0; k < N; k++) Console.Write("*");
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}