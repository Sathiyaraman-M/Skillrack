#include <stdio.h>

int main()
{
    char str[101];
    scanf("%[^\n]", str);
    int maxWordLength, index = 0, wordLength = 0;
    maxWordLength = (maxWordLength < wordLength ? wordLength : maxWordLength);
    while(str[index] != '\0')
    {
        wordLength++;
        if(str[index] == ' ')
        {
            if(maxWordLength < wordLength - 1)
            {
                maxWordLength = wordLength - 1;
            }
            wordLength = 0;
        }
        index++;
    }
    printf("%d", maxWordLength);
    return 0;
}