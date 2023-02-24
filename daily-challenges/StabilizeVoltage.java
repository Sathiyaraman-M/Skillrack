import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var X = sc.nextInt();
        var Y = sc.nextInt();
        sc.close();
        var diff = X > Y ? X - Y : Y - X;
        System.out.print(diff <= 50 ? "yes" : "no");
    }
}