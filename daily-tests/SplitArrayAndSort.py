N, P = map(int, input().split())
L = list(map(int, input().strip().split()))
print(sorted(L[:P]), sorted(L[P:]), sep = '\n')