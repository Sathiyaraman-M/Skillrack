A, B, C = map(int, input().split())
print(sum(set([A * B, B * C, C * A])))