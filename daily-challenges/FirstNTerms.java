import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var N = new Scanner(System.in).nextInt();
        var index = 1;
        for(int i = 1; i <= N; i++) {
            var sum = 0;
            for(int j = 0; j < i; j++) {
                sum += index++;
            }
            System.out.print(sum + " ");
        }
    }
}