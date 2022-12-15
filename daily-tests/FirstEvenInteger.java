import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var N = sc.nextInt();
        var turn = false;
        for(int i = 0; i < N; i++) {
            var val = sc.nextInt();
            if (val % 2 == 0) turn = true;
            if (!turn) 
                continue;
            else 
                System.out.print(val + " ");
        }
    }
}