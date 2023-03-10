void reverseAlphanumeric(char *str)
{
    int len = strlen(str);
    char* result = (char *)malloc(len * sizeof(char));
    int lastIndex = nextAlNumIndex(len, str);
    for(int i = 0; i < len; i++) {
        if(!isalnum(*(str + i))) {
            //printf("%c\n", *(str + i));
            result[i] = *(str + i);
        } else {
            result[i] = *(str + lastIndex);
            lastIndex = nextAlNumIndex(lastIndex, str);
        }
    }
    for(int i = 0; i < len; i++) {
        str[i] = result[i];
    }
}

int nextAlNumIndex(int curr, char *str) {
    int i = curr - 1;
    while(i >= 0) {
        if(isalnum(*(str + i))) {
            return i;
        }
        i--;
    }
    return 0;
}