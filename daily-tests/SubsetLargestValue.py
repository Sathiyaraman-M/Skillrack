N, T = map(int, input().split())
L = list(map(int, input().split()))
R = [max(L[i: i + T]) for i in range(0, N, T)]
print(*R)