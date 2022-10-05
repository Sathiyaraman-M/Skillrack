using System;

public class Program
{
    static bool IsNotPrime(long N)
    {
        if(N == 2) return false;
        if(N % 2 == 0) return true;
        for(long i = 3; i <= Math.Sqrt(N); i += 2)
            if(N % i == 0)
                return true;
        return false;
    }
    
    static void Main()
    {
        var N = long.Parse(Console.ReadLine());
        var limit = 2 * N;
        for(var i = N + 1; i < limit; i++)
        {
            if(!IsNotPrime(i))
            {
                Console.Write(i);
                return;
            }
        }
    }
}