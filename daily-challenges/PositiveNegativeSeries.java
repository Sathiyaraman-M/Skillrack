import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var N = new Scanner(System.in).nextInt();
        var sum = 0;
        for(int i = 1; i <= N; i++) {
            if(i % 2 == 0) {
                sum -= i;
            } else {
                sum += i;
            }
        }
        System.out.print(sum);
    }
}