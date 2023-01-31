import java.util.*;
public class Hello {
    private static boolean isVowel(char ch) {
        ch = Character.toUpperCase(ch);
        return ch != 'A' && ch != 'E' && ch != 'I' && ch != 'O' && ch != 'U';
    }
    
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var ch = sc.next().charAt(0);
        ch++;
        while(!isVowel(ch)) {
            ch++;
        }
        System.out.print(ch);
    }
}