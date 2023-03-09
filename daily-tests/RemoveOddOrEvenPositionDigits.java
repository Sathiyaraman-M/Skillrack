import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var N = sc.nextLine().trim();
        sc.close();
        var len = N.length();
        var val = Long.parseLong(N);
        var start = val % 2 == 0 ? 0 : 1;
        var result = "";
        for(int i = start; i < len; i += 2) {
            result += N.charAt(i);
        }
        System.out.print(Long.parseLong(result));
    }
}