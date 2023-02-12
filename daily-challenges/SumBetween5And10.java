import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var N = sc.nextInt();
        var sum = 0;
        var addMode = false;
        for(int i = 0; i < N; i++) {
            var input = sc.nextInt();
            if(input == 5 && !addMode) {
                addMode = true;
            } else if(input == 10) {
                addMode = false;
            } else if(addMode) {
                sum += input;
            }
        }
        System.out.print(sum);
    }
}