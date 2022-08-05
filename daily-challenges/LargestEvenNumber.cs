using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        var inputs = Console.ReadLine().Trim().Split(' ').Select(long.Parse).ToList();
        var digits = new int[10];
        while(inputs[0] > 0)
        {
            digits[inputs[0] % 10]++;
            inputs[0] /= 10;
        }
        while(inputs[1] > 0)
        {
            digits[inputs[1] % 10]++;
            inputs[1] /= 10;
        }
        int unit = -1;
        for(int i = 2; i <= 8; i += 2)
        {
            if(digits[i] > 0)
            {
                digits[i]--;
                unit = i;
                break;
            }
        }
        if(unit == -1)
        {
            Console.Write("-1");
            return;
        }
        for(int i = 9; i >= 0; i--)
        {
            while(digits[i]-- > 0)
            {
                Console.Write(i);
            }
        }
        Console.Write(unit);
    }
}