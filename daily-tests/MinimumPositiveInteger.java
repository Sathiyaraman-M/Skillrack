import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var X = sc.nextInt();
        var Y = sc.nextInt() + 1;
        var Z = sc.nextInt();
        for(int i = 1; i < X; i++)
        {
            if(i % Z == 0)
            {
                System.out.print(i);
                return;
            }
        }
        while(Y % Z != 0) 
            Y++;
        System.out.print(Y);
    }
}