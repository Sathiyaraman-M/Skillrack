import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var input = new Scanner(System.in).nextLine().trim();
        var len = input.length();
        for(int i = 0; i < len; i += 2) {
            System.out.print(input.charAt(i));
        }
        System.out.println();
        for(int i = 1; i < len; i += 2) {
            System.out.print(input.charAt(i));
        }
    }
}