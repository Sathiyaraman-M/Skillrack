N = int(input())
L = list(map(int, input().split()))
Odd = []
Even = []
for i in range(N):
    if L[i] % 2 == 0:
        Even.append(i + 1)
    else:
        Odd.append(i + 1)
if len(Odd) == 1:
    print(*Odd)
else:
    print(*Even)