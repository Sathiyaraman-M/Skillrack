import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var X = sc.nextInt();
        var Y = sc.nextInt();
        sc.close();
        var rem1 = X % 100;
        var rem2 = Y % 100;
        X += rem2 - rem1;
        Y += rem1 - rem2;
        System.out.print(X * Y);
    }
}