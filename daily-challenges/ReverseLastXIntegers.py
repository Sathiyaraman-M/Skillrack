N, X = map(int, input().split())
L = list(map(int, input().split()))
print(*L[N - X:][::-1])