using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        var countArr = new List<int>();
        for(int i = 1; i <= (N / 2) + 1; i++)
            countArr.Add(i);
        int currCount = countArr.Count;
        int startVal = 1;
        bool reverse = false;
        /**Pattern First Half**/
        for(int i = 0; i < N / 2; i++)
        {
            var values = Enumerable.Range(startVal, currCount).ToList();
            
            if(reverse) values.Reverse();
            
            /**Initial star part**/
            for(int j = 0; j < 3 * i; j++)
                Console.Write("-");
            
            /**Values in first half of the line**/
            for(int j = 0; j < values.Count(); j++)
                Console.Write(j != values.Count() - 1 ? $"{values[j]}-" : $"{values[j]}");
            
            /**Hyphens in line middle**/
            for(int j = 0; j < N - 2 * (i + 1); j++)
                Console.Write("-");
            
            /**Values in second half of the line**/
            for(int j = values.Count() - 1; j >= 0; j--)
                Console.Write(j != 0 ? $"{values[j]}-" : $"{values[j]}");
            
            currCount--;
            startVal = values.Max() + 1;
            Console.WriteLine();
            reverse = !reverse;
        }
        
        /**Pattern Interval scene**/
        for(int i = 0; i < 3 * (N / 2); i++)
            Console.Write("-");
        Console.WriteLine("0");
        currCount++;
        startVal = 1;
        reverse = !reverse;
        
        /**Pattern Second Half**/
        for(int i = (N / 2) - 1; i >= 0; i--)
        {
            var values = Enumerable.Range(startVal, currCount).ToList();
            
            if(reverse) values.Reverse();
            
            for(int j = 0; j < 3 * i; j++)
                Console.Write("-");
                
            for(int j = 0; j < values.Count(); j++)
                Console.Write(j != values.Count() - 1 ? $"{values[j]}-" : $"{values[j]}");
                
            for(int j = 0; j < N - 2 * (i + 1); j++)
                Console.Write("-");
            
            for(int j = values.Count - 1; j >= 0; j--)
                Console.Write(j != 0 ? $"{values[j]}-" : $"{values[j]}");
                
            currCount++;
            startVal = values.Max() + 1;
            Console.WriteLine();
            reverse = !reverse;
        }
        
        /**Pattern Climax**/
        //Console.WriteLine("Working");
    }
}