import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var string = sc.nextLine().trim();
        var X = sc.nextInt();
        var len = string.length();
        for(int i = 0; i < len - X; i++) {
            System.out.print(string.charAt(i));
        }
        for(int i = 0; i < X; i++) {
            System.out.print(string.charAt(len - i - 1));
        }
    }
}