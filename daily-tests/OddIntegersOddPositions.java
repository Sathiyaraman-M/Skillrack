import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var N = sc.nextInt();
        for(int i = 0; i < N; i++) {
            var value = sc.nextInt();
            if(i % 2 == 0 && value % 2 != 0) {
                System.out.print(value + " ");
            }
        }
    }
}