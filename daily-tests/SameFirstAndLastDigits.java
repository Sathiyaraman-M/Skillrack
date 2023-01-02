import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var N = sc.nextInt();
        var success = false;
        while(N > 0) {
            var input = sc.next().trim();
            var len = input.length();
            var first = Integer.parseInt(String.valueOf(input.charAt(0)));
            var last = Integer.parseInt(String.valueOf(input.charAt(len - 1)));
            if(first == last) {
                System.out.print(input + " ");
                success = true;
            }
            N--;
        }
        if(!success) {
            System.out.print("-1");
        }
    }
}