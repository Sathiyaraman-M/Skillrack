import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var X = sc.nextInt();
        var Y = sc.nextInt();
        if(X < Y) {
            for(int i = X; i <= Y; i++) {
                if(i % 2 == 0) {
                    System.out.print(i + " ");
                }
            }
        } else {
            for(int i = X; i >= Y; i--) {
                if(i % 2 == 0) {
                    System.out.print(i + " ");
                }
            }
        }
    }
}