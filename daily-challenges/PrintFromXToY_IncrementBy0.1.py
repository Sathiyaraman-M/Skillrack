X, Y = map(lambda x: int(float(x) * 10), input().strip().split())
print(*[i / 10 for i in range(X, Y + 1)])