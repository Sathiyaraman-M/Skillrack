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
        int cache;
        for(int i = N - 1; i >= 0; i--)
        {
            if(stack.Count == 0)
            {
                stack.Push(list[i]);                
            }
            else if(stack.Peek() > list[i])
            {
                cache = stack.Peek();
                stack.Push(list[i]);
                list[i] = cache;
            }
            else
            {
                while(stack.Count > 0)
                {
                    if(stack.Peek() <= list[i]) stack.Pop();
                    else break;
                }                
                if(stack.Count == 0)
                {
                    stack.Push(list[i]);                
                }
                else
                {
                    cache = stack.Peek();
                    stack.Push(list[i]);
                    list[i] = cache;
                }
            }
        }
        for(int i = 0; i < N; i++)
        {
            Console.Write(list[i] + " ");
        }
    }
}