A, B = map(str, input().split())
N = int(B)
X = int(A[N - 1])
Y = int(A[0 - N])
print(X * Y)