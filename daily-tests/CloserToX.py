N, X = map(int, input().split())
L = list(map(int, input().split()))
H = list(map(lambda a: abs(X - a), L))
Min = min(H)
for i in range(N):
    if H[i] == Min:
        print(L[i], end = ' ')