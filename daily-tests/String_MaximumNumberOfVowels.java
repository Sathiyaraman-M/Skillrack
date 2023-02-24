import java.util.*;
public class Hello {
    static boolean isVowel(char ch) {
        ch = Character.toLowerCase(ch);
        return ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u';
    }
    
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var s1 = sc.nextLine().trim();
        var s2 = sc.nextLine().trim();
        var c1 = 0;
        var c2 = 0;
        for(int i = 0; i < s1.length(); i++) {
            c1 += isVowel(s1.charAt(i)) ? 1 : 0;
        }
        for(int i = 0; i < s2.length(); i++) {
            c2 += isVowel(s2.charAt(i)) ? 1 : 0;
        }
        System.out.print((c1 == 0 && c2 == 0) ? "-1" : (c1 >= c2 ? s1 : s2));
    }
}