N, K = map(int, input().split())
L = sorted(list(map(int, input().split())))
print(sum(L[N - K:]))