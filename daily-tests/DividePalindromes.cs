using System;

class Hello
{
    static string Input;
    
    static bool IsPalindrome(int i, int j)
    {
        while(i < j)
        {
            if(Input[i] != Input[j])
                return false;
            i++;
            j--;
        }
        return true;
    }
    
    static void Main()
    {
    	Input = Console.ReadLine().Trim();
        int len = Input.Length;
    	for(int i = 1; i < len; i++)
    	{
    	    if(IsPalindrome(0, i - 1) && IsPalindrome(i, len - 1))
    	    {
    	        Console.Write(Input.Substring(0, i) + " " + Input.Substring(i));
    	        break;
    	    }
    	}
    }
}