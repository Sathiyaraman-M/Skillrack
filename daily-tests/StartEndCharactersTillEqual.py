S = input().strip()
L = len(S)
for i in range(L // 2):
    print(S[i], S[L - i - 1], sep = '', end = '')
    if S[i] == S[L - i - 1]:
        exit()
if L % 2 != 0:
    print(S[L // 2])