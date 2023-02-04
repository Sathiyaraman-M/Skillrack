S1 = input().strip().split()
S2 = input().strip().split()
L = min(len(S1), len(S2))
for i in range(L):
    print(S1[i] if len(S1[i]) >= len(S2[i]) else S2[i], end = ' ')
if len(S1) == L:
    print(*S2[L:])
else:
    print(*S1[L:])