W, N = map(int, input().split())
L = list(map(int, input().split()))
A = [0 for i in range(W)]
for i in range(N):
    A[i % W] += L[i]
print(*A)
