#include <stdio.h>
#define LASTALPHA 'z'
int isVowel(char ch)
{
    return (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u');
}

int main()
{
    char ch;
    scanf("%c", &ch);
    ch = tolower(ch);
    do 
    {
        printf("%c ", ch);
        ch++;
    }
    while((ch <= LASTALPHA) && !isVowel(ch));
    return 0;
}
