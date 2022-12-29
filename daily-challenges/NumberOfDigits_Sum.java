import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var X = sc.nextInt();
        var Y = sc.nextInt();
        var sum = X + Y;
        var temp = sum;
        var cpy = X;
        while(temp != 0) {
            temp /= 10;
            cpy--;
        }
        System.out.print(cpy == 0 ? sum : X);
    }
}