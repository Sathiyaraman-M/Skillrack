using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        var list = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        var stack = new Stack<int>();
        for(int i = N - 1; i >= 0; i--)
        {
            if(stack.Count == 0)
            {
                stack.Push(list[i]);
            }
            else
            {
                if(stack.Peek() == list[i]) stack.Pop();
                else stack.Push(list[i]);
            }            
        }
        if(stack.Count == 0)
        {
            Console.Write(-1);
            return;
        }
        while(stack.Count > 0)
        {
            Console.Write(stack.Pop() + " ");
        }        
    }
}