import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var input = new Scanner(System.in).nextLine().trim();
        var len = input.length();
        for(int i = 0; i < len; i++)
        {
            for(int j = 0; j < i; j++)
            {
                System.out.print("*");
            }
            for(int j = 0; j < len - i; j++)
            {
                System.out.print(input.charAt(j));
            }
            System.out.println();
        }
    }
}