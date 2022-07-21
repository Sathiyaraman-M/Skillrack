using System;
using System.Collections.Generic;
using System.Linq;
 
public class Hello
{
    static void Main()
    {
        var tokens = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        int N = tokens[0], P = tokens[1], Q = tokens[2];
        var list = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        int currSpeed = 40, maxSpeed = 40;
        foreach(var i in list)
        {
            if(i == P) 
                currSpeed += i;
            else if(i == Q) 
                currSpeed -= i;
            if(maxSpeed < currSpeed)
                maxSpeed = currSpeed;
        }
        Console.Write(maxSpeed);
    }
}