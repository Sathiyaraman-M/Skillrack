import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var input = sc.nextLine().trim();
        var N = sc.nextInt();
        System.out.print(input.substring(0, N));
        System.out.print(input.substring(input.length() - N));
    }
}