N = int(input())
L = [1, 0]
for i in range(N - 2):
    L = [L[0] + L[1]] + L
print(*L)