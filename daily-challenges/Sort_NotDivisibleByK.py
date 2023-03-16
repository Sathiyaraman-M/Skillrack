N, K = map(int, input().split())
L = list(map(int, input().split()))
D = sorted([i for i in L if i % K != 0])
I = 0
for i in range(N):
    if L[i] % K == 0:
        print(L[i], end = ' ')
    else:
        print(D[I], end = ' ')
        I += 1