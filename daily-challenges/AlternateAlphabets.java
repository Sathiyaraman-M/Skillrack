import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var input = new Scanner(System.in).nextLine().trim();
        var len = input.length() / 2;
        for(int i = 0; i < len; i++) {
            System.out.print(input.charAt(len + i));
            System.out.print(input.charAt(i));
        }
	}
}