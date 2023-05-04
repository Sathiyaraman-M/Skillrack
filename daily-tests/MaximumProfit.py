N, M = map(int, input().split())
L = sorted(list(map(int, input().split())))
print((-1) * sum([i for i in L[:M] if i < 0]))