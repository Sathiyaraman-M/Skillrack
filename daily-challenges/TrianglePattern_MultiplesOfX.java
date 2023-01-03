import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var N = sc.nextInt();
        var X = sc.nextInt();
        var index = 1;
        for(int i = 0; i < N; i++) {
            for(int j = 0; j <= i; j++) {
                if(index % X != 0) {
                    System.out.printf("%d ", index);
                } else {
                    System.out.print("* ");
                }
                index++;
            }
            System.out.println();
        }
    }
}