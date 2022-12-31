import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var N = sc.nextInt();
        var X = sc.nextInt();
        var result = 0;
        while(N > 0) {
            result += N % 10;
            N /= 10;
        }
        result *= X;
        System.out.print(result);
    }
}