import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var N = sc.nextInt();
        long sum = 0;
        for(int i = 0; i < N; i++) {
            var value = sc.nextLong();
            long rem = value % 10;
            if (rem == 0) {
                sum += value;
                continue;
            }
            if(rem >= 5) {
                value += 10 - rem;
            } else {
                value -= rem;
            }
            sum += value;
        }
        System.out.print(sum);
    }
}