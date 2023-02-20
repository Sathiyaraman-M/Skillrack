N = int(input())
L = input().strip().split()
R = []
if len(L[1]) == 2 or len(L[1]) == 3:
    R.append(L[0])
for i in range(1, N - 1):
    if (len(L[i - 1]) == 2 or len(L[i - 1]) == 3) and (len(L[i + 1]) == 2 or len(L[i + 1] ) == 3):
        R.append(L[i])
if len(L[N - 2]) == 2 or len(L[N - 2]) == 3:
    R.append(L[N - 1])
if len(R) > 0:
    print(*R)
else:
    print(-1)