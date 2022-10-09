#include<stdio.h>
#include<stdlib.h>

int alphaCount[128] = {0};

void printAlphabet(char *str, int len)
{
    for(int i = 0; i < len; i++)
        if(alphaCount[str[i]] == 1)
            printf("%c", str[i]);
}

int main()
{
    char str1[101], str2[101];
    scanf("%s", str1);
    scanf("%s", str2);
    int len1 = strlen(str1);
    int len2 = strlen(str2);
    int index = 0;
    while(index < len1)
        alphaCount[(int)str1[index++]]++;
    index = 0;
    while(index < len2)
        alphaCount[(int)str2[index++]]++;
    printAlphabet(str1, len1);
    printAlphabet(str2, len2);
} 
