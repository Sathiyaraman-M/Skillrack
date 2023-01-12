S = input().strip()
for i in range(len(S) - 1):
    print(*[chr(j) for j in range(ord(S[i]) + 1, ord(S[i + 1]))], sep = '', end = '')