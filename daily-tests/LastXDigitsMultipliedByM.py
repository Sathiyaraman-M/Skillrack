N = input().strip()
X, M = map(int, input().split())
print(M * int(N[len(N) - X:]))