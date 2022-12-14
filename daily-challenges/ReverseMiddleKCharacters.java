import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var input = sc.nextLine().trim();
        var len = input.length();
        var N = sc.nextInt();
        System.out.print(input.substring(0, (len / 2) - (N / 2)));
        for(int i = 0; i < N; i++) {
            System.out.print(input.charAt(N % 2 != 0 ? (len / 2) + (N / 2) - i : (len / 2) + (N / 2) - i - 1));
        }
        System.out.print(input.substring(N % 2 != 0 ? (len / 2) + (N / 2) + 1 : (len / 2) + (N / 2)));
    }
}