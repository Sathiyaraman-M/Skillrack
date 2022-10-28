using System;

public class Program
{
    static void Main()
    {
        var input1 = Console.ReadLine().Trim();
        var input2 = Console.ReadLine().Trim();
        int len1 = input1.Length, len2 = input2.Length, index = 0, count = 0;
        while(index < len1)
        {
            input1 = input1.Substring(2) + input1.Substring(0, 2);
            if(index < len2)
            {
                if(input1[index] == input2[index])
                    count++;
            }
            input1 = input1.Substring(len1 - 2) + input1.Substring(0, len1 - 2);
            index++;
        }
        Console.Write(count == len1 ? "Yes" : "No");
    }
}