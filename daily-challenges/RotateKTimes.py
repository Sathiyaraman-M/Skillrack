N = int(input())
L = list(map(int, input().split()))
K = int(input()) % N

for i in range(K):
    L = [L[-1]] + L[:N - 1]

print(*L)