S = input().strip()
L = len(S)
I = 0
for i in range((L // 2) + 1):
    P = list(S[I: I + i + 1])
    if len(P) == 0:
        break
    while len(P) != i + 1:
        P.append('*')
    print(*P[::-1])
    I += i + 1