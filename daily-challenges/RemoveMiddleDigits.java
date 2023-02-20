import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var N = sc.nextLine().trim();
        var len = N.length();
        System.out.printf("%c%c", N.charAt(0), N.charAt(len - 1));
    }
}