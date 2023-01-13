using System;

public class Program 
{
    static void Main() 
    {
        var input = Console.ReadLine().Trim().Split(' ');
        var X = int.Parse(input[0]);
        var Y = int.Parse(input[1]);
        var min = X < Y ? X : Y;
        for(int i = 1; i <= min; i++) 
        {
            if(X % i == 0 && Y % i == 0) 
            {
                Console.Write(i + " ");
            }
        }
    }
}