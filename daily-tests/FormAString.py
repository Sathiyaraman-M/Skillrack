N, X = map(int, input().split())
S = chr(ord('a') + X - 1)
for i in range(N - 1):
    S += chr(ord('a') + (i % X))
print(S)