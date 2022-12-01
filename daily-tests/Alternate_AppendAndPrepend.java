import java.util.*;
public class Hello {
    public static void main(String[] args) {
		var sc = new Scanner(System.in);
        var N = sc.nextInt();
        var string = "";
        for(int i = 0; i < N; i++) {
            var input = sc.next().trim();
            if(i % 2 == 0) {
                string = string + input;
            } else {
                string = input + string;
            }
        }
        System.out.print(string);
	}
}