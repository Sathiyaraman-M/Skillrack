N = int(input())
I = input().strip().split()
L = list(map(lambda x: sum(map(int, [i for i in x])), I))
MSum = max(L)
M = int(L[0])
for i in range(N):
    if L[i] == MSum and int(I[i]) > M:
        M = int(I[i])
print(M)