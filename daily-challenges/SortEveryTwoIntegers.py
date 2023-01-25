N = int(input())
L = list(map(int, input().split()))
for i in range(0, N, 2):
    if L[i] > L[i + 1]:
        L[i], L[i + 1] = L[i + 1], L[i]
print(*L)