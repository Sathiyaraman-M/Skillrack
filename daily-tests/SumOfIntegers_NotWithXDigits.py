N, X = map(int, input().split())
S = sum(list(map(int, [i for i in input().strip().split() if len(i) != X])))
print(S if S != 0 else -1)