import java.util.*;
public class Hello {

    public static void main(String[] args) {
		var sc = new Scanner(System.in);
		var M = sc.nextInt();
		var N = sc.nextInt();
		var X = sc.nextInt();
		var sum = 0;
		for(int i = M; i <= N; i++)
		{
		    if(i % X == 0)
		    {
		        sum += i;
		    }
		}
        System.out.print(sum != 0 ? sum : -1);
	}
}