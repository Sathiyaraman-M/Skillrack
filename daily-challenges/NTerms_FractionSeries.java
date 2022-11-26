import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var N = new Scanner(System.in).nextInt();
        var index = 0;
        for(int i = 1; i <= N; i++) {
            if(i % 4 == 1) {
                System.out.printf("%d/4 ", (index * 4) + 1);
            } else if(i % 4 == 2) {
                System.out.printf("%d/2 ", (index * 2) + 1);
            } else if(i % 4 == 3) {
                System.out.printf("%d/4 ", (index * 4) + 3);
            } else {
                System.out.printf("%d ", ++index);
            }
        }
    }
}