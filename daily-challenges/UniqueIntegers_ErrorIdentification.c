#include<stdio.h>

int main()
{
    int N;
    scanf("%d", &N);
    int value, numberCount[1001] = {0};
    for(int ctr = 0; ctr < N; ctr++){
        scanf("%d", &value);
        if(numberCount[value]++ == 1){
            printf("NO");
            return 0;
        }
    }
    printf("YES");
    return 0;
}
