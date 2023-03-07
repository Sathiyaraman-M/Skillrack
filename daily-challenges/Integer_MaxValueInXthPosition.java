import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var N = sc.nextInt();
        var arr = new long[N];
        for(int i = 0; i < N; i++) {
            arr[i] = sc.nextLong();
        }
        var X = sc.nextInt();
        sc.close();
        var divisor = Math.pow(10, X);
        var maxDigit = (int)((arr[0] % divisor) * 10 / divisor);
        var max = arr[0];
        for(int i = 1; i < N; i++) {
            var curr = (int)((arr[i] % divisor) * 10 / divisor);
            if(curr > maxDigit) {
                maxDigit = curr;
                max = arr[i];
            }
        }
        System.out.print(max);
    }
}