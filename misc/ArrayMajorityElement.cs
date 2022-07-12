using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        var list = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        int majority = list[0], counter = 1;
        for(int i = 1; i < N; i++)
        {
            if(list[i] == majority) counter++;
            else
            {
                counter--;
                if(counter == 0)
                {
                    majority = list[i];
                    counter = 1;
                }
            }
        }
        if(counter > 0)
        {
            int actualCount = 0;
            foreach(var i in list)
                if(i == majority) 
                    actualCount++;
            if(actualCount > N / 2)
            {
                Console.Write(majority);
                return;
            }
        }
        Console.Write("No Majority Element");
    }
}