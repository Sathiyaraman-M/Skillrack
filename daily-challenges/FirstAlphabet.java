import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var input = new Scanner(System.in).next().trim();
        int val = (int)input.charAt(0);
        for(int i = 1; i < input.length(); i++)
            if((int)input.charAt(i) < val)
                val = (int)input.charAt(i);
        System.out.print((char)val);
	}
}