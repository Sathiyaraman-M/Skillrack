using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        var M = new int[100, 100];
        int row = 0, col = 0;
        for(int i = 0; i < 100; i++)
        {
            var input = Console.ReadLine();
            if(string.IsNullOrEmpty(input)) 
                break;
            var list = input.Trim().Split(' ').Select(int.Parse).ToList();
            col = list.Count;
            for(int j = 0; j < col; j++)
                M[i, j] = list[j];
            row++;
        }
        for(int i = 0; i < col; i++)
        {
            for(int j = 0; j < row; j++)
                Console.Write(M[j, i] + " ");
            Console.WriteLine();
        }
    }
}