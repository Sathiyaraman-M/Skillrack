import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var input = new Scanner(System.in).nextLine().trim();
        var len = input.length();
        for(int i = 0; i < len; i++) {
            var digit = Integer.parseInt(String.valueOf(input.charAt(i)));
            for(int j = 0; j < digit; j++) {
                System.out.print(digit);
            }
        }
    }
}
