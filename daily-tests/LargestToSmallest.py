X, Y = map(int, input().split())
(X, Y) = (X, Y) if X < Y else (Y, X)
print(*range(Y, X - 1, -1))