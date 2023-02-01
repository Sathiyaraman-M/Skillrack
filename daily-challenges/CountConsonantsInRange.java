import java.util.*;
public class Hello {
    private static boolean isVowel(char ch) {
        ch = Character.toLowerCase(ch);
        return ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u';
    }
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var ch1 = sc.next().charAt(0);
        var ch2 = sc.next().charAt(0);
        var count = 0;
        for(char i = ch1; i <= ch2; i++) {
            if(!isVowel(i)) {
                count++;
            }
        }
        System.out.print(count);
    }
}