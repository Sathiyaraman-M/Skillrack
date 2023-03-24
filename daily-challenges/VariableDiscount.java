import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var P = sc.nextFloat();
        if(P <= 1000) {
            System.out.printf("%.2f", P * 0.1);
        } else {
            System.out.printf("%.2f", (P - 1000) * 0.05 + 100);
        }
    }
}