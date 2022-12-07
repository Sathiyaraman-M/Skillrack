import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var N = new Scanner(System.in).nextLong();
        var even = N % 2 == 0;
        var result = even ? 0 : 1;
        while(N > 0) {
            var digit = N % 10;
            if(even) {
                result += digit;
            } else {
                result *= digit;
            }
            N /= 10;
        }
        System.out.println(result);
    }
}