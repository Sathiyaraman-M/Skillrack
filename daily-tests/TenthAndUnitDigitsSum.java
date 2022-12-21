import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var N = sc.nextInt();
        var tens = 0;
        var units = 0;
        for(int i = 0; i < N; i++) {
            var value = sc.nextInt();
            tens += value / 10;
            units += value % 10;
        }
        System.out.printf("%d %d", tens, units);
    }
}