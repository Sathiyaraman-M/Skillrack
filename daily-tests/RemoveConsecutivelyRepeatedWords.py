S = input().split()
R = []
if len(S) == 1:
    print(*S)
    exit()
if S[0] != S[1]:
    R.append(S[0])
for i in range(1, len(S) - 1):
    if S[i] != S[i - 1] and S[i] != S[i + 1]:
        R.append(S[i])
if S[-2] != S[-1]:
    R.append(S[-1])
print(*R)