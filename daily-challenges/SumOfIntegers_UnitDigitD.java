import java.util.*;
public class Hello {

    public static void main(String[] args) {
		//Your Code Here
        var sc = new Scanner(System.in);
        int N = sc.nextInt();
        int D = sc.nextInt();
        int C = 0;
        for(int i = 1; i <= N; i++)
            if(i % 10 == D)
                C += i;
        System.out.print(C != 0 ? C : -1);
	}
}