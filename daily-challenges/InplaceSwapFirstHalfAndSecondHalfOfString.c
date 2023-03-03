void swapFirstHalfSecondHalf(char *str)
{
    int len = strlen(str);
    for(int i = 0; i < len / 2; i++) {
        char temp = str[i];
        str[i] = str[(len / 2) + i];
        str[(len / 2) + i] = temp;
    }
}