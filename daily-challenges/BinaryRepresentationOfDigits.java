import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var N = new Scanner(System.in).nextLong();
        var input = String.valueOf(N);
        var len = input.length();
        for(int i = 0; i < len; i++) {
            var digit = Integer.parseInt(String.valueOf(input.charAt(i)));
            System.out.printf("%d%d%d%d\n", 
                (digit & 8) != 0 ? 1 : 0, 
                (digit & 4) != 0 ? 1 : 0, 
                (digit & 2) != 0 ? 1 : 0, 
                (digit & 1) != 0 ? 1 : 0);
        }
    }
}