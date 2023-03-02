S = input().strip()
for i in range(len(S)):
    if S[i] == ' ' and S[i - 1] != ' ':
        print(' ', end = '')
    elif S[i] == ' ' and S[i - 1] == ' ':
        print('*', end = '')
    else:
        print(S[i], end = '')